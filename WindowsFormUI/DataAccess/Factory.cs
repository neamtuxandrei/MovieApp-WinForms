using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormUI.DataAccess.Interfaces;

namespace WindowsFormUI.DataAccess
{
    public static class Factory
    {
        public static ICustomerRepository CreateCustomerRepository()
        {
            return new CustomerRepository();
        }

        public static IMovieRepository CreateMovieRepository()
        {
            return new MovieRepository();
        }

        public static IRentalRepository CreateRentalRepository()
        {
            return new RentalRepository();
        }
    }
}
