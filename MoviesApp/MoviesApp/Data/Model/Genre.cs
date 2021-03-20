using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesApp.Data.Model
{
    /// <summary>
    /// Клас, който отговаря за обект "жанр" в приложението.
    /// Върху този клас, с помощта на EntityFramework.Core се създава таблица "Genres", която съдържа всички 
    /// жанрове на филми на приложението.
    /// </summary>
    [Table("Genres")]
    public class Genre
    {
        /// <summary>
        /// Номер на жанр
        /// Уникално поле
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Име на жанра
        /// </summary>
        [Required]
        public string Title { get; set; }
        /// <summary>
        /// Колекция от връзки между жанра и филмите от този жанр
        /// </summary>
        public IList<MovieGenre> MoviesGenres{ get; set; }
        /// <summary>
        /// Конструктор на класа
        /// </summary>
        /// <param name="title">Име на жанра</param>
        public Genre( string title)
        {
            Title = title;
        }
    }
}
