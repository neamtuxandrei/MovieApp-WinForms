using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormUI.Enums;
using WindowsFormUI.Models;
using WindowsFormUI.Models.Interfaces;

namespace WindowsFormUI.DataAccess
{
    public class MovieRepository : IMovieRepository
    {

        public IMovie GetMovieById(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                var movie = connection.QueryFirst($"SELECT * FROM dbo.Movies WHERE Id = {id}");
                return new Movie(movie.Id, movie.Title, movie.Producer, movie.ProductionYear, movie.Duration);
            }
        }
        public IEnumerable<IMovie> GetMovies()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                // return connection.Query<Models.Customer>($"select * from Customers where LastName ='{lastName}' ").ToList();
                IEnumerable<IMovie> movies = connection.Query<Movie>("SELECT * FROM dbo.Movies");
                foreach (Movie movie in movies)
                {
                    IEnumerable<dynamic> genres = connection.Query("SELECT g.Name FROM dbo.Movie_genres mg INNER JOIN dbo.Genres g ON g.Id = mg.GenreId WHERE mg.MovieId = @Id"
                        , new { movie.Id });
                    foreach (var genre in genres)
                    {
                        string genreTest = genre.Name;
                        Enum.TryParse(genreTest, out Genre genreToAdd);
                        movie.Genres.Add(genreToAdd);
                    }
                }
                return movies;
            }
        }
        public void InsertMovie(string title, List<Genre> genres, string producer, string productionYear, string duration)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                // add movie
                IMovie movie = new Movie(title, producer, productionYear, duration);
                connection.Execute("dbo.InsertMovie @Title, @Producer, @ProductionYear, @Duration", movie);
                // add genres to movie
                int movieId = connection.QueryFirst<int>("Select m.Id FROM Movies m WHERE m.Title = @Title", new { movie.Title });
                AddGenresToMovie(genres, movieId, connection);
            }
        }
        public void UpdateMovie(int id, string title, List<Genre> genres, string producer, string productionYear, string duration)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                Movie movie = new Movie(id, title, producer, productionYear, duration);
                connection.Execute("UPDATE dbo.Movies SET Title=@Title, Producer=@Producer, ProductionYear=@ProductionYear, Duration=@Duration WHERE Id = @Id", movie);
                // remove genres and add the new ones
                connection.Execute($"DELETE FROM dbo.Movie_genres WHERE MovieId = {id}");
                AddGenresToMovie(genres, id, connection);
            }
        }
        private void AddGenresToMovie(IEnumerable<Genre> genres, int movieId, IDbConnection connection)
        {
            using (connection)
            {
                foreach (Genre genre in genres)
                {
                    string Genre = genre.ToString();
                    int genreId = connection.QueryFirst<int>("SELECT g.Id FROM Genres g WHERE Name= @Genre", new { Genre });
                    connection.Execute($"INSERT INTO dbo.Movie_genres (MovieId,GenreId)  VALUES ({movieId},{genreId})");
                }
            }
        }

        public void DeleteMovie(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                //Movie movie = new Movie
                //{
                //    Id = id
                //};
                // 1: 
                connection.Execute($"DELETE FROM dbo.Movie_genres WHERE MovieId = {id} ");
                // 2:
                connection.Execute($"DELETE FROM dbo.Movies WHERE Id = {id} ");
                // Ordinea este importanta
            }
        }



    }
}
