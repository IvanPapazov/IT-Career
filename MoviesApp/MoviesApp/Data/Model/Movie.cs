using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MoviesApp.Data.Model
{
    /// <summary>
    /// Клас, който отговаря за обект "филм" в приложението.
    /// Върху този клас, с помощта на EntityFramework.Core се създава таблица "Movies", която съдържа всички 
    /// филми на приложението.
    /// </summary>
    [Table("Movies")]
    public class Movie
    {
        /// <summary>
        /// Номер на филм 
        /// Уникално поле
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Име на филм
        /// Задължително поле
        /// </summary>
        [Required]
        public string MovieTitle { get; set; }
        /// <summary>
        /// Година на създаване на филма
        /// </summary>
        public int MovieYear { get; set; }
        /// <summary>
        /// Продължителност на филма(в минути)
        /// </summary>
        public int Duration { get; set; }
        /// <summary>
        /// Държава, в която филмът е създаден
        /// </summary>
        public string MovieCountry { get; set; }
        /// <summary>
        /// Описание на филма
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Номер на директора на филма
        /// </summary>
        public int DirectorId { get; set; }
        /// <summary>
        /// Директор на филма
        /// </summary>
        public Director Director { get; set; }
        /// <summary>
        /// Булева променлива, отговаряща за това дали филмът е харесан или не
        /// </summary>
        public bool IsLiked { get; set; }
        /// <summary>
        /// Колекция от връзки между филма и актьорите, участващи в него
        /// </summary>
        public IList<MovieActor> MoviesActors { get; set; }
        /// <summary>
        /// Колекция от връзки между филма и жанровете на филма
        /// </summary>
        public IList<MovieGenre> MoviesGenres { get; set; }
        /// <summary>
        /// Колекция от връзки между филма и плейлистите, в които е добавен
        /// </summary>
        public IList<MoviePlaylist> MoviesPlaylists { get; set; }
        /// <summary>
        /// Конструктор на класа
        /// </summary>
        /// <param name="movieTitle">Име на филма</param>
        /// <param name="movieYear">Година на създаване на филма</param>
        /// <param name="duration">Продължителност на филма</param>
        /// <param name="movieCountry">Държава</param>
        /// <param name="directorId">Номер на режисьора на филма</param>
        /// <param name="description">Описание</param>
        public Movie(string movieTitle, int movieYear, int duration, string movieCountry, int directorId, string description)
        {
            this.MovieTitle = movieTitle;
            this.MovieYear = movieYear;
            this.Duration = duration;
            this.MovieCountry = movieCountry;
            this.DirectorId = directorId;
            this.Description = description;
            this.IsLiked = false;
        }
    }
}