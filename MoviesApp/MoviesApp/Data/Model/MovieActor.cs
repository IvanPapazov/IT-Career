using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesApp.Data.Model
{
    /// <summary>
    /// Клас, който отговаря за обект от тип връзка между обекти "филм-актьори" в приложението.
    /// Върху този клас, с помощта на EntityFramework.Core се създава таблица "MoviesActors", която съдържа всички 
    /// връзки между филм и актьори, участващи в него, на приложението.
    /// </summary>
    [Table("MoviesActors")]
    public class MovieActor
    {
        /// <summary>
        /// Номер на филма
        /// </summary>
        public int MovieId { get; set; }
        /// <summary>
        /// Филм, участващ във връзката
        /// </summary>
        public Movie Movie { get; set; }
        /// <summary>
        /// Номер на актьора
        /// </summary>
        public int ActorId { get; set; }
        /// <summary>
        /// Актьор, участващ във филма
        /// </summary>
        public Actor Actor { get; set; }
        /// <summary>
        /// Конструктор на класа
        /// </summary>
        /// <param name="movieId">Номер на филм</param>
        /// <param name="actorId">Номер на актьор</param>
        public MovieActor(int movieId, int actorId)
        {
            MovieId = movieId;
            ActorId = actorId;
        }
    }
}