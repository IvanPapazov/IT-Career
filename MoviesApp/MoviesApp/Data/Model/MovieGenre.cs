using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesApp.Data.Model
{
    /// <summary>
    /// Клас, който отговаря за обект от тип връзка между обекти "филм-жанрове" в приложението.
    /// Върху този клас, с помощта на EntityFramework.Core се създава таблица "MoviesGenres", която съдържа всички 
    /// връзки между филм и неговите жанрове на приложението.
    /// </summary>
    [Table("MoviesGenres")]
    public class MovieGenre
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
        /// Номер на жанра
        /// </summary>
        public int GenreId { get; set; }
        /// <summary>
        /// Жанр, описващ филма
        /// </summary>
        public Genre Genre { get; set; }
        /// <summary>
        /// Конструктор на класа
        /// </summary>
        /// <param name="movieId">Номер на филма</param>
        /// <param name="genreId">Номер на жанра</param>
        public MovieGenre(int movieId, int genreId)
        {
            MovieId = movieId;
            GenreId = genreId;
        }
    }
}
