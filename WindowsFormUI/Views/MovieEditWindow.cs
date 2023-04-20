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
    public partial class MovieEditWindow : Form
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMovie _movie;
        public MovieEditWindow(IMovieRepository movieRepository, IMovie movie)
        {
            InitializeComponent();
            _movieRepository = movieRepository;
            _movie = movie;
            UpdateGenreListBox();
        }

        private void SaveMovieButton_Click(object sender, EventArgs e)
        {
            //de vazut varianta mai optima
            var genresChecked = GenreListBox.CheckedItems.Cast<Genre>().ToList();
            _movie.Genres.Clear();
            //  List<Genre> genresToAdd = new List<Genre>();
            // List<Genre> genresToRemove = _movie.Genres.Except<Genre>(genresChecked).ToList();
            //  foreach(Genre genre in genresChecked)
            //  {
            //   if (!_movie.Genres.Contains(genre))
            //   genresToAdd.Add(genre);
            //   }
            _movieRepository.UpdateMovie(_movie.Id, TitleInput.Text, genresChecked, ProducerInput.Text, ProductionYearInput.Text, DurationInput.Text);
            MessageBox.Show("Movie updated!");
        }
        private void UpdateGenreListBox()
        {
            var genres = Enum.GetValues(typeof(Genre)).Cast<Genre>().ToList();
            GenreListBox.DataSource = genres;
            // check the genres of the movie
            foreach (Genre genre in genres)
            {
                if (_movie.Genres.Contains(genre))
                {
                    int genreIndex = ((int)genre);
                    GenreListBox.SetItemChecked(genreIndex, true);
                }
            }
        }
        private void TurnOnOffInputs()
        {
            if (TitleInput.Enabled == false)
            {
                TitleInput.Enabled = true;
                ProducerInput.Enabled = true;
                ProductionYearInput.Enabled = true;
                DurationInput.Enabled = true;
                GenreListBox.Enabled = true;
            }
            else
            {
                TitleInput.Enabled = false;
                ProducerInput.Enabled = false;
                ProductionYearInput.Enabled = false;
                DurationInput.Enabled = false;
                GenreListBox.Enabled = false;
            }
        }

        private void MovieEditWindow_Load(object sender, EventArgs e)
        {
            SaveMovieButton.Enabled = false;
            GenreListBox.Enabled = false;
            TitleInput.Text = _movie.Title;
            ProducerInput.Text = _movie.Producer;
            ProductionYearInput.Text = _movie.ProductionYear;
            DurationInput.Text = _movie.Duration;
        }

        private void LockUnlockInfo_Click(object sender, EventArgs e)
        {
            TurnOnOffInputs();
            if (TitleInput.Enabled == false)
                SaveMovieButton.Enabled = true;
            else
                SaveMovieButton.Enabled = false;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInWindow logIn = new LogInWindow();
            logIn.Show();
        }

        private void MoviesWindowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieListWindow moviesWindow = new MovieListWindow(_movieRepository);
            moviesWindow.Show();
        }
    }
}
