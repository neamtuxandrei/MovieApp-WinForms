using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormUI.Enums;

namespace WindowsFormUI.Models.Interfaces
{
    public interface IMovie
    {
        int Id { get; set; }
        string Title { get; set; }
        List<Genre> Genres { get; set; }
        string Producer { get; set; }
        string ProductionYear { get; set; }
        string Duration { get; set; }
        string FullInfo { get; }
        string GenresInfo { get; }
        string GetGenresToString();

    }
}
