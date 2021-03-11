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
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public IList<MovieActor> MoviesActors { get; set; }
        public IList<MovieGenre> MoviesGenres { get; set; }
        public IList<MoviePlaylist> MoviesPlaylists { get; set; }

        public Movie(string movieTitle, int movieYear, int duration, string movieCountry, int directorId, string description)
        {
            this.MovieTitle = movieTitle;
            this.MovieYear = movieYear;
            this.Duration = duration;
            this.MovieCountry = movieCountry;
            this.DirectorId = directorId;
            this.Description = description;     
        }
    }
}