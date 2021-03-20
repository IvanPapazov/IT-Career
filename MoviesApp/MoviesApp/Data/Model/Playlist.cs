using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesApp.Data.Model
{
    /// <summary>
    /// Клас, който отговаря за обект "плейлист" в приложението.
    /// Върху този клас, с помощта на EntityFramework.Core се създава таблица "Playlists", която съдържа всички 
    /// плейлисти на приложението.
    /// </summary>
    [Table("Playlists")]
    public class Playlist
    {
        /// <summary>
        /// Номер на плейлист
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Име на плейлист
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Колекция от връзки между плейлиста и филмите, намиращи се  него.
        /// </summary>
        public IList<MoviePlaylist> MoviesPlaylists { get; set; }
        /// <summary>
        /// Конструктор на класа
        /// </summary>
        /// <param name="name">Име на плейлиста</param>
        public Playlist(string name)
        {
            Name = name;
        }
    }
}
