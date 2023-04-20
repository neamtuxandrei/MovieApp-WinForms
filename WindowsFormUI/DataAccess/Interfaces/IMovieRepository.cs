using System.Collections.Generic;
using WindowsFormUI.Enums;
using WindowsFormUI.Models;
using WindowsFormUI.Models.Interfaces;

namespace WindowsFormUI.DataAccess
{
    public interface IMovieRepository
    {
        IMovie GetMovieById(int id);
        void DeleteMovie(int id);
        IEnumerable<IMovie> GetMovies();
        void InsertMovie(string title, List<Genre> genres, string producer, string productionYear, string duration);
        void UpdateMovie(int id, string title,List<Genre> genres, string producer, string productionYear, string duration);
    }
}