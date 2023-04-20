using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormUI.DataAccess.Interfaces;
using WindowsFormUI.Models;
using WindowsFormUI.Models.Interfaces;

namespace WindowsFormUI.DataAccess
{
    public class RentalRepository : IRentalRepository
    {
        public void InsertRental(int customerId, int movieId, decimal rentPrice, DateTime rentDate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                connection.Execute($"INSERT INTO dbo.Rentals (CustomerId,MovieId,RentPrice,RentDate) VALUES ({customerId},{movieId},{rentPrice},'{rentDate}')");
            }
        }
        public void DeleteRental(int customerId, int movieId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                connection.Execute($"DELETE FROM dbo.Rentals WHERE CustomerId = {customerId} AND MovieId = {movieId} ");
            }
        }
        public IEnumerable<dynamic> GetAllRentals()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                var rentals = connection.Query("SELECT * FROM dbo.Rentals");
                //List<IRental> getRentals = new List<IRental>();
                //foreach(dynamic rental in rentals)
                //{
                //    IRental rentalToAdd = new Rental(rental.CustomerId, rental.MovieId, rental.RentPrice, rental.DateTime);
                //    getRentals.Add(rentalToAdd);
                //}
                return rentals ;
            }

        }
        public IEnumerable<IRental> GetCustomerRentalsById(int customerId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                // return connection.Query<Models.Customer>($"select * from Customers where LastName ='{lastName}' ").ToList();
                var output = connection.Query($"SELECT m.Id,m.Title,m.Producer,m.ProductionYear,m.Duration,r.RentPrice,r.RentDate" +
                                              $" FROM Rentals r" +
                                              $" INNER JOIN Movies m ON m.Id = r.MovieId " +
                                              $" INNER JOIN Customers c ON c.Id = r.CustomerId " +
                                              $" WHERE c.Id = {customerId}");
                List<IRental> rentals = new List<IRental>();
                foreach (var rental in output)
                {
                    IMovie movie = new Movie(rental.Id, rental.Title, rental.Producer, rental.ProductionYear, rental.Duration);
                    IRental movieRental = new Rental(movie, rental.RentPrice, rental.RentDate);
                    rentals.Add(movieRental);
                }
                return rentals;
            }
        }
    }
}
