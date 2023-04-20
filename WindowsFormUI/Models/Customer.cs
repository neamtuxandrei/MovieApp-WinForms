using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WindowsFormUI.Models.Interfaces;

namespace WindowsFormUI.Models
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{LastName} {FirstName} -- {EmailAddress} -- {PhoneNumber}";
            }
        }

        public Customer()
        {

        }

        public Customer(string firstName, string lastName, string phoneNumber, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }
        public Customer(int id, string firstName, string lastName, string phoneNumber, string emailAddress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }

       
    }
}
