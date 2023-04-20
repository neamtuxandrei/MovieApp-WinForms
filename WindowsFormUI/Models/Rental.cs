using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormUI.Models.Interfaces;

namespace WindowsFormUI.Models
{
    public class Rental : IRental
    {
        public ICustomer Customer { get; set; }
        public IMovie Movie { get; set; }
        public decimal RentPrice { get; set; }
        public DateTimeOffset RentDate { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{Movie.Title} on {RentDate:f} ({RentPrice} LEI)";
            }
        }
        public string FullInfoAndCustomer
        {
            get
            {
                return $"{Customer.LastName} rented {Movie.Title} on {RentDate:f} ({RentPrice} LEI)";
            }
        }
        public Rental()
        {

        }
        public Rental(IMovie movie,decimal rentPrice, DateTimeOffset rentDate)
        {
            Movie = movie;
            RentPrice = rentPrice;
            RentDate = rentDate;
        }
        public Rental(ICustomer customer,IMovie movie, decimal rentPrice, DateTimeOffset rentDate)
        {
            Customer = customer;
            Movie = movie;
            RentPrice = rentPrice;
            RentDate = rentDate;
        }
       //public Rental(int customerId, int movieId, decimal rentPrice, DateTime rentDate)
       // {
       //     Customer.Id = customerId;
       //     Movie.Id = movieId;
       //     RentPrice = rentPrice;
       //     RentDate = rentDate;
       // }

    }

}
