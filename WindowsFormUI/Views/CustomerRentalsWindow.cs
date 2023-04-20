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
using WindowsFormUI.Models.Interfaces;

namespace WindowsFormUI.UIWindows.Customer
{
    public partial class CustomerRentalsWindow : Form
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IRentalRepository _rentalRepository;
        private readonly ICustomer _customer;
        private readonly IEnumerable<IRental> _rentals;
        public CustomerRentalsWindow(ICustomerRepository customerRepository,IMovieRepository movieRepository,ICustomer customer,IRentalRepository rentalRepository)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _movieRepository = movieRepository;
            _rentalRepository = rentalRepository;
            _customer = customer;
            _rentals = _rentalRepository.GetCustomerRentalsById(_customer.Id);
            UpdateRentalListBox();
        }

        private void DeleteRentalButton_Click(object sender, EventArgs e)
        {
            IRental rental = (IRental)RentalsListBox.SelectedItem;
            _rentalRepository.DeleteRental(_customer.Id, rental.Movie.Id);
            UpdateRentalListBox();
            MessageBox.Show("Rental deleted");
            // nu se updateaza rentalListBox fara reload pag
            this.Hide();
            CustomerRentalsWindow rentals = new CustomerRentalsWindow(_customerRepository, _movieRepository,_customer,_rentalRepository);
            rentals.Show();
        }
        private void UpdateRentalListBox()
        {  
            if (_rentals != null)
            {
                RentalsListBox.DataSource = _rentals;
                RentalsListBox.DisplayMember = "FullInfo";
            }
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomeWindow adminHomeWindow = new AdminHomeWindow();
            adminHomeWindow.Show();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersListWindow customersList = new CustomersListWindow(_customerRepository,_movieRepository,_rentalRepository);
            customersList.Show();
        }

        private void AddRentalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerAddRentalWindow rentalWindow = new CustomerAddRentalWindow(_customerRepository, _movieRepository,_customer,_rentalRepository);
            rentalWindow.Show();
        }

        private void RentalsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            IRental rental = (IRental)RentalsListBox.SelectedItem;
            if (rental == null)
            {
                DeleteRentalButton.Enabled = false;
            }
            else
            {
                DeleteRentalButton.Enabled = true;
            }
        }

        private void CustomerRentalsWindow_Load(object sender, EventArgs e)
        {
            RentalsListBox.ClearSelected();
            DeleteRentalButton.Enabled = false;
            CustomerName.Text = _customer.LastName + " " + _customer.FirstName;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text) == false)
            {
                var rentalsSearched = _rentals.Where(movie => movie.FullInfo.Contains(SearchTextBox.Text));
                RentalsListBox.DataSource = rentalsSearched.ToList();
            }
            else if (SearchTextBox.Text == "")
            {
                UpdateRentalListBox();
            }
        }
    }
}
