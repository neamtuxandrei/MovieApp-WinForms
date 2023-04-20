using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormUI.Enums;
using WindowsFormUI.Models.Interfaces;

namespace WindowsFormUI.Models
{
    public class Movie : IMovie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public string Producer { get; set; }
        public string ProductionYear { get; set; }
        public string Duration { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{Title} by {Producer} -- {GetGenresToString()}";
            }

        }
        public string GenresInfo
        {
            get
            {
                return $"{GetGenresToString()}";
            }
        }

        public string GetGenresToString()
        {
            string genres = "";
            foreach (Genre genre in Genres)
            {
                genres += genre.ToString() + " ";
            }
            return genres;
        }



        public Movie(string title, string producer, string productionYear, string duration)
        {
            Title = title;
            Producer = producer;
            ProductionYear = productionYear;
            Duration = duration;

        }
        public Movie(int id, string title, string producer, string productionYear, string duration)
        {
            Id = id;
            Title = title;
            Producer = producer;
            ProductionYear = productionYear;
            Duration = duration;
        }
        public Movie()
        {

        }



    }
}
