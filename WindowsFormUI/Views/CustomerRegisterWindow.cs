using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormUI;
using WindowsFormUI.DataAccess;
using WindowsFormUI.DataAccess.Interfaces;
using WindowsFormUI.Models;
using WindowsFormUI.Models.Interfaces;
using WindowsFormUI.UIWindows;

namespace WindowsFormUI
{
    public partial class CustomerRegisterWindow : Form
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IRentalRepository _rentalRepository;
        public CustomerRegisterWindow(ICustomerRepository customerRepository,IMovieRepository movieRepository,IRentalRepository rentalRepository)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _movieRepository = movieRepository;
            _rentalRepository = rentalRepository;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            IEnumerable<ICustomer> customers = _customerRepository.GetCustomers();
            var customerExist = customers.FirstOrDefault(customer => customer.EmailAddress == EmailInput.Text);
            if (customerExist != null)
            {
                MessageBox.Show("Customer already exists");
                return;
            }
            if (IsValidEmail(EmailInput.Text) && IsValidPhoneNumber(PhoneNrInput.Text) && IsValidName(FirstNameInput.Text) && IsValidName(LastNameInput.Text))
            {
                _customerRepository.InsertCustomer(FirstNameInput.Text, LastNameInput.Text, PhoneNrInput.Text, EmailInput.Text);
                MessageBox.Show("Added succesfully");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Invalid inputs");
            }
        }
        private void ClearFields()
        {
            FirstNameInput.Clear();
            LastNameInput.Clear();
            PhoneNrInput.Clear();
            EmailInput.Clear();
        }

        private bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Any(char.IsDigit))
                return false;
            else
                return true;

        }
        private bool IsValidPhoneNumber(string phone)
        {
            bool isNumber = Int32.TryParse(phone, out _);
            if (isNumber)
                return true;
            else
                return false;
        }
        private bool IsValidEmail(string email)
        {
            if (email.EndsWith("@yahoo.com") || email.EndsWith("@gmail.com") || email.EndsWith("@iCloud.com"))
                return true;
            else
                return false;
        }

        private void CustomersWindowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersListWindow customersWindow = new CustomersListWindow(_customerRepository,_movieRepository,_rentalRepository);
            customersWindow.Show();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomeWindow adminHomeWindow = new AdminHomeWindow();
            adminHomeWindow.Show();
        }
    }
}
