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
    public partial class CustomerAddRentalWindow : Form
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IRentalRepository _rentalRepository;
        private readonly IEnumerable<IMovie> _movies;
        private readonly ICustomer _customer;
        public CustomerAddRentalWindow(ICustomerRepository customerRepository, IMovieRepository movieRepository,ICustomer customer,IRentalRepository rentalRepository)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _movieRepository = movieRepository;
            _rentalRepository = rentalRepository;
            _customer = customer;
            _movies = _movieRepository.GetMovies();
            UpdateMoviesListBox();
        }
        private void AddRentalButton_Click(object sender, EventArgs e)
        {
            if (IsPriceValid(PriceInput.Text))
            {
                IMovie movieSelected = (IMovie)MoviesListBox.SelectedItem;
                _rentalRepository.InsertRental(_customer.Id, movieSelected.Id, decimal.Parse(PriceInput.Text), RentDateTime.Value);
                MessageBox.Show("Rental inserted");
                PriceInput.Text = String.Empty;
            }
            else
                MessageBox.Show("Invalid Price");
        }

        private bool IsPriceValid(string price)
        {
            bool isNumber = Decimal.TryParse(price, out _);
            if (isNumber)
                return true;
            else
                return false;
        }
        private void CustomersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersListWindow customersList = new CustomersListWindow(_customerRepository,_movieRepository,_rentalRepository);
            customersList.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRentalsWindow customerRental = new CustomerRentalsWindow(_customerRepository,_movieRepository,_customer,_rentalRepository);
            customerRental.Show();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text) == false)
            {
                var moviesSearched = _movies.Where(movie => movie.FullInfo.Contains(SearchTextBox.Text));
                MoviesListBox.DataSource = moviesSearched.ToList();
            }
            else if (SearchTextBox.Text == "")
            {
                UpdateMoviesListBox();
            }
        }

        private void UpdateMoviesListBox()
        {
            MoviesListBox.DataSource = _movies;
            MoviesListBox.DisplayMember = "FullInfo";
        }

        private void CustomerAddRentalMovie_Load(object sender, EventArgs e)
        {
            MoviesListBox.ClearSelected();
            AddRentalButton.Enabled = false;
            CustomerName.Text = _customer.LastName + " " + _customer.FirstName;
            RentDateTime.MinDate = DateTime.Today;
            RentDateTime.Format = DateTimePickerFormat.Custom;
            RentDateTime.CustomFormat = "dd/MM/yyyy hh:mm";
        }

        private void MoviesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            IMovie movieSelected = (IMovie)MoviesListBox.SelectedItem;
            if (movieSelected == null)
            {
                AddRentalButton.Enabled = false;
            }
            else
            {
                AddRentalButton.Enabled = true;
            }
        }
    }
}
