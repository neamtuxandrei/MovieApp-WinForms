using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormUI.Models;
using WindowsFormUI.Models.Interfaces;

namespace WindowsFormUI.DataAccess.Interfaces
{
    public interface IRentalRepository
    {
        void InsertRental(int customerId, int movieId, decimal rentPrice, DateTime rentDate);
        void DeleteRental(int customerId, int movieId);
        IEnumerable<IRental> GetCustomerRentalsById(int customerId);
        IEnumerable<dynamic> GetAllRentals();
    }
}
