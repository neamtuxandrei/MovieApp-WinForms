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
    public partial class RentalsWindow : Form
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IRentalRepository _rentalRepository;
        private readonly IEnumerable<dynamic> _rentals;
        private readonly List<IRental> _movieRentals;

        public RentalsWindow(ICustomerRepository customerRepository, IMovieRepository movieRepository,IRentalRepository rentalRepository)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _movieRepository = movieRepository;
            _rentalRepository = rentalRepository;
            _rentals = _rentalRepository.GetAllRentals();
            _movieRentals = new List<IRental>();
            UpdateRentalsListBox();
        }
        private void UpdateRentalsListBox()
        {
            foreach (var rental in _rentals)
            {
                IRental movieRental = new Rental(_customerRepository.GetCustomerById(rental.CustomerId),
                                                          _movieRepository.GetMovieById(rental.MovieId),
                                                          rental.RentPrice, rental.RentDate);
                _movieRentals.Add(movieRental);
            }
            RentalsListBox.DataSource = _movieRentals;
            RentalsListBox.DisplayMember = "FullInfoAndCustomer";
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomeWindow home = new AdminHomeWindow();
            home.Show();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text) == false)
            {
                var rentalsSearched = _movieRentals.Where(rentals => rentals.FullInfo.Contains(SearchTextBox.Text));
                RentalsListBox.DataSource = rentalsSearched.ToList();
            }
            else if (SearchTextBox.Text == "")
            {
                UpdateRentalsListBox();
            }
        }

        private void RentalsWindow_Load(object sender, EventArgs e)
        {
            RentalsListBox.ClearSelected();
        }
    }
}
