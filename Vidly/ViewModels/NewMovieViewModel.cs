using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> GenreTypes { get; set; }
        public Movie Movie { get; set; }

        public string Title { get; set; }
    }
}