using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using WindowsFormUI.Models;
using WindowsFormUI.DataAccess.Interfaces;
using WindowsFormUI.Models.Interfaces;

namespace WindowsFormUI.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {

        public ICustomer GetCustomerById(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                var customer = connection.QueryFirst($"SELECT * FROM dbo.Customers WHERE Id = {id} ");
                return new Customer(customer.Id, customer.FirstName, customer.LastName, customer.PhoneNumber, customer.EmailAddress);
            }
        }
        public void DeleteCustomer(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                //Customer customer = new Customer
                //{
                //    Id = id
                //};
                // connection.Execute("dbo.DeleteCustomer @Id", customer);
                connection.Execute($"DELETE FROM dbo.Customers WHERE Id = {id} ");
            }
        }
        public void UpdateCustomer(int id, string firstName, string lastName, string phoneNumber, string emailAddress)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                ICustomer customer = new Customer(id, firstName, lastName, phoneNumber, emailAddress);
                connection.Execute("dbo.UpdateCustomer @Id, @FirstName, @LastName, @PhoneNumber, @EmailAddress", customer);
            }
        }
        public IEnumerable<ICustomer> GetCustomers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                // return connection.Query<Models.Customer>($"select * from Customers where LastName ='{lastName}' ").ToList();
                var output = connection.Query<Customer>("dbo.GetAllCustomers");
                return output;
            }
        }


        public void InsertCustomer(string firstName, string lastName, string phoneNumber, string emailAddress)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringVal("MovieAppDB")))
            {
                //List<Models.Customer> customers = new List<Models.Customer>();
                //customers.Add(new Models.Customer(firstName, lastName, phoneNumber, emailAddress)); 
                ICustomer customer = new Customer(firstName, lastName, phoneNumber, emailAddress);
                connection.Execute("dbo.InsertCustomer @FirstName, @LastName, @PhoneNumber, @EmailAddress", customer);

            }
        }

       


    }
}
