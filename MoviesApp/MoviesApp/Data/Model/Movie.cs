using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MoviesApp.Data.Model
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MovieTitle { get; set; }
        public int MovieYear { get; set; }
        public int Duration { get; set; }
        public string MovieCountry { get; set; }
        public string Description { get; set; }
        public IList<MovieActor> MoviesActors { get; set; }
        public Movie(string movieTitle, int movieYear, int duration, string movieCountry, string description)
        {
            MovieTitle = movieTitle;
            MovieYear = movieYear;
            Duration = duration;
            MovieCountry = movieCountry;
            Description = description;
        }
    }
}