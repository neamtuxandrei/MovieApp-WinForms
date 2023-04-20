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

namespace WindowsFormUI.UIWindows
{
    public partial class AdminHomeWindow : Form
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IRentalRepository _rentalRepository;
        public AdminHomeWindow()
        {
            InitializeComponent();
            _customerRepository = Factory.CreateCustomerRepository();
            _movieRepository = Factory.CreateMovieRepository();
            _rentalRepository = Factory.CreateRentalRepository();
        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieListWindow movieList = new MovieListWindow(_movieRepository);
            movieList.Show();

        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersListWindow customerList = new CustomersListWindow(_customerRepository,_movieRepository,_rentalRepository);
            customerList.Show();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInWindow logIn = new LogInWindow();
            logIn.Show();
        }

        private void RentalsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalsWindow rentals = new RentalsWindow(_customerRepository, _movieRepository,_rentalRepository);
            rentals.Show();
        }
    }
}
