using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesApp.Data.Model
{
    [Table("Genres")]
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public IList<MovieGenre> MoviesGenres{ get; set; }
        public Genre( string title)
        {
            Title = title;
        }
    }
}
