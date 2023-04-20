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
using WindowsFormUI.Models;
using WindowsFormUI.Models.Interfaces;
using WindowsFormUI.UIWindows.Movie;

namespace WindowsFormUI.UIWindows
{
    public partial class MovieListWindow : Form
    {
        private readonly IEnumerable<IMovie> _movies;
        private readonly IMovieRepository _movieRepository;

        public MovieListWindow(IMovieRepository movieRepository)
        {
            InitializeComponent();
            _movieRepository = movieRepository;
            _movies = _movieRepository.GetMovies();
            UpdateMoviesListBox();
        }

        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            IMovie movieSelected = (IMovie)MoviesListBox.SelectedItem;
            _movieRepository.DeleteMovie(movieSelected.Id);
            // De vazut de ce nu se updateaza lista, chiar si cu .Refresh() sau UpdateMoviesListBox.
            UpdateMoviesListBox();
            MessageBox.Show("Movie deleted");
            this.Hide();
            MovieListWindow movieList = new MovieListWindow(_movieRepository);
            movieList.Show();
        }
        private void UpdateMoviesListBox()
        {
            MoviesListBox.DataSource = _movies;
            MoviesListBox.DisplayMember = "FullInfo";
        }

        private void EditMovieButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            IMovie movieSelected = (IMovie)MoviesListBox.SelectedItem;
            MovieEditWindow movieEdit = new MovieEditWindow(_movieRepository, movieSelected);
            movieEdit.Show();
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

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomeWindow home = new AdminHomeWindow();
            home.Show();
        }
        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieRegisterWindow movie = new MovieRegisterWindow(_movieRepository);
            movie.Show();
        }

        private void MovieListWindow_Load(object sender, EventArgs e)
        {
            MoviesListBox.ClearSelected();
            EditMovieButton.Enabled = false;
            DeleteMovieButton.Enabled = false;
        }

        private void MoviesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            IMovie movieSelected = (IMovie)MoviesListBox.SelectedItem;
            if (movieSelected == null)
            {
                EditMovieButton.Enabled = false;
                DeleteMovieButton.Enabled = false;
            }
            else
            {
                EditMovieButton.Enabled = true;
                DeleteMovieButton.Enabled = true;
            }
        }
    }
}
