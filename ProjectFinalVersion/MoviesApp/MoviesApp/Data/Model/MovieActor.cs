using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesApp.Data.Model
{
    [Table("MoviesActors")]  
    public class MovieActor
    {    
        public int ActorId { get; set; }
        public Actor Actor { get; set; }       

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public MovieActor(int movieId, int actorId)
        {
            MovieId = movieId;
            ActorId = actorId;
        }
    }
}