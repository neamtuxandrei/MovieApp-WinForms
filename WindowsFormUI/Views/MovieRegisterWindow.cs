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
using WindowsFormUI.Enums;
using WindowsFormUI.Models.Interfaces;

namespace WindowsFormUI.UIWindows.Movie
{
    public partial class MovieRegisterWindow : Form
    {
        private readonly IMovieRepository _movieRepository;
        public MovieRegisterWindow(IMovieRepository movieRepository)
        {
            InitializeComponent();
            _movieRepository = movieRepository;
            UpdateGenreListBox();
        }
        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            IEnumerable<IMovie> movies = _movieRepository.GetMovies();
            var movieExist = movies.FirstOrDefault(movie => movie.Title == TitleInput.Text);
            if (movieExist != null)
            {
                MessageBox.Show("Movie already exists");
                return;
            }
            if (IsStringInputValid(TitleInput.Text) && IsStringInputValid(ProducerInput.Text) && IsYearValid(ProductionYearInput.Text) && IsDurationValid() )
            {
                var genresChecked = GenreListBox.CheckedItems.Cast<Genre>().ToList();
                _movieRepository.InsertMovie(TitleInput.Text, genresChecked, ProducerInput.Text, ProductionYearInput.Text, DurationInput.Text);
                MessageBox.Show("Added succesfully");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Invalid inputs");
            }

        }
        private void UpdateGenreListBox()
        {
            var genres = Enum.GetValues(typeof(Genre)).Cast<Genre>().ToList();
            GenreListBox.DataSource = genres;
        }

        private void ClearFields()
        {
            TitleInput.Clear();
            ProducerInput.Clear();
            ProductionYearInput.Clear();
            DurationInput.Clear();
            GenreListBox.ClearSelected();
        }

        private bool IsDurationValid()
        {
            // de stabilit detalii
            return true;
        }
        private bool IsStringInputValid(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Any(char.IsDigit))
                return false;
            else
                return true;
        }
        private bool IsYearValid(string year)
        {
            bool isNumber = Int32.TryParse(year, out _);
            if (isNumber)
                return true;
            else
                return false;
        }



        private void MoviesWindowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieListWindow moviesWindow = new MovieListWindow(_movieRepository);
            moviesWindow.Show();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInWindow logIn = new LogInWindow();
            logIn.Show();
        }
    }
}
