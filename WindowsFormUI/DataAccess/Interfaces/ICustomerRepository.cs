using System.Collections.Generic;
using WindowsFormUI.DataAccess.Interfaces;
using WindowsFormUI.Models;
using WindowsFormUI.Models.Interfaces;

namespace WindowsFormUI.DataAccess
{
    public interface ICustomerRepository 
    {
        void DeleteCustomer(int id);
        IEnumerable<ICustomer> GetCustomers();
        void InsertCustomer(string firstName, string lastName, string phoneNumber, string emailAddress);
        void UpdateCustomer(int id, string firstName, string lastName, string phoneNumber, string emailAddress);
        ICustomer GetCustomerById(int id);
       
    }
}