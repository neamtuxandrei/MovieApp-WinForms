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
using WindowsFormUI.UIWindows.Customer;

namespace WindowsFormUI.UIWindows
{
    public partial class CustomersListWindow : Form
    {
        private readonly IEnumerable<ICustomer> _customers;
        private readonly ICustomerRepository _customerRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IRentalRepository _rentalRepository;

        public CustomersListWindow(ICustomerRepository customerRepository, IMovieRepository movieRepository,IRentalRepository rentalRepository)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _movieRepository = movieRepository;
            _rentalRepository = rentalRepository;
            _customers = _customerRepository.GetCustomers();
            UpdateCustomersListBox();

        }

        private void UpdateCustomersListBox()
        {
            CustomersListBox.DataSource = _customers;
            CustomersListBox.DisplayMember = "FullInfo";
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text) == false)
            {
                var customersSearched = _customers.Where(customer => customer.FullInfo.Contains(SearchTextBox.Text));
                CustomersListBox.DataSource = customersSearched.ToList();
            }
            else if (SearchTextBox.Text == "")
            {
                UpdateCustomersListBox();
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRegisterWindow registerCustomer = new CustomerRegisterWindow(_customerRepository,_movieRepository,_rentalRepository);
            registerCustomer.Show();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            ICustomer customerSelected = (ICustomer)CustomersListBox.SelectedItem;
            _customerRepository.DeleteCustomer(customerSelected.Id);
            // De vazut de ce nu se updateaza lista, chiar si cu .Refresh() sau UpdateCustomersListBox.
            UpdateCustomersListBox();
            MessageBox.Show("Customer deleted");
            this.Hide();
            CustomersListWindow customersList = new CustomersListWindow(_customerRepository,_movieRepository,_rentalRepository);
            customersList.Show();
        }
        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ICustomer customerSelected = (ICustomer)CustomersListBox.SelectedItem;
            CustomerEditWindow customerEdit = new CustomerEditWindow(customerSelected, _customerRepository,_movieRepository,_rentalRepository);
            customerEdit.Show();
        }

        private void CustomersWindow_Load(object sender, EventArgs e)
        {
            CustomersListBox.ClearSelected();
            EditCustomerButton.Enabled = false;
            DeleteCustomerButton.Enabled = false;
            RentalsButton.Enabled = false;
        }

        private void CustomersListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ICustomer customerSelected = (ICustomer)CustomersListBox.SelectedItem;
            if (customerSelected == null)
            {
                EditCustomerButton.Enabled = false;
                DeleteCustomerButton.Enabled = false;
                RentalsButton.Enabled = false;
            }
            else
            {
                EditCustomerButton.Enabled = true;
                DeleteCustomerButton.Enabled = true;
                RentalsButton.Enabled = true;
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomeWindow home = new AdminHomeWindow();
            home.Show();
        }
        
        private void RentalsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ICustomer customerSelected = (ICustomer)CustomersListBox.SelectedItem;
            CustomerRentalsWindow customerRentals = new CustomerRentalsWindow(_customerRepository, _movieRepository, customerSelected,_rentalRepository);
            customerRentals.Show();
        }

        private void CustomersListBox_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            ICustomer customerSelected = (ICustomer)CustomersListBox.SelectedItem;
            CustomerAddRentalWindow customerRentals = new CustomerAddRentalWindow(_customerRepository, _movieRepository, customerSelected,_rentalRepository);
            customerRentals.Show();
        }
    }
}
