using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormUI.DataAccess;
using WindowsFormUI.DataAccess.Interfaces;
using WindowsFormUI.Models;
using WindowsFormUI.Models.Interfaces;

namespace WindowsFormUI.UIWindows
{
    public partial class CustomerEditWindow : Form
    {
        private readonly ICustomer _customer;
        private readonly ICustomerRepository _customerRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IRentalRepository _rentalRepository;
        public CustomerEditWindow(ICustomer customer, ICustomerRepository customerRepository, IMovieRepository movieRepository,IRentalRepository rentalRepository)
        {
            InitializeComponent();
            _customer = customer;
            _customerRepository = customerRepository;
            _movieRepository = movieRepository;
            _rentalRepository = rentalRepository;
        }

        private void CustomersWindowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersListWindow customersWindow = new CustomersListWindow(_customerRepository,_movieRepository,_rentalRepository);
            customersWindow.Show();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInWindow logIn = new LogInWindow();
            logIn.Show();
        }

        private void LockUnlockInfo_Click(object sender, EventArgs e)
        {
            TurnOnOffInputs();
            if (FirstNameInput.Enabled == false)
                SaveCustomerButton.Enabled = true;
            else
                SaveCustomerButton.Enabled = false;
        }

        private void SaveCustomerButton_Click(object sender, EventArgs e)
        {
            _customerRepository.UpdateCustomer(_customer.Id, FirstNameInput.Text, LastNameInput.Text, PhoneNrInput.Text, EmailInput.Text);
            MessageBox.Show("Customer updated!");
        }

        private void CustomerEditWindow_Load(object sender, EventArgs e)
        {
            SaveCustomerButton.Enabled = false;
            FirstNameInput.Text = _customer.FirstName;
            LastNameInput.Text = _customer.LastName;
            PhoneNrInput.Text = _customer.PhoneNumber;
            EmailInput.Text = _customer.EmailAddress;
        }

        private void TurnOnOffInputs()
        {
            if (FirstNameInput.Enabled == false)
            {
                FirstNameInput.Enabled = true;
                LastNameInput.Enabled = true;
                PhoneNrInput.Enabled = true;
                EmailInput.Enabled = true;
            }
            else
            {
                FirstNameInput.Enabled = false;
                LastNameInput.Enabled = false;
                PhoneNrInput.Enabled = false;
                EmailInput.Enabled = false;
            }
        }
    }
}
