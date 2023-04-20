using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAdmin { get; set; } = false;

        public User(string firstName,string lastName, string password, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            PhoneNumber = phoneNumber;
        }
    }
}
