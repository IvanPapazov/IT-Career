using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MoviesApp.Data.Model
{
    [Table("Actors")]
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        public IList<MovieActor> MoviesActors { get; set; }
        public Actor(string firstName, string lastName, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }
    }
}