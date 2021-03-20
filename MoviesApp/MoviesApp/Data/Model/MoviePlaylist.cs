using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MoviesApp.Data.Model
{
    /// <summary>
    /// Клас, който отговаря за обект от тип връзка между обекти "филм-плейлисти" в приложението.
    /// Върху този клас, с помощта на EntityFramework.Core се създава таблица "MoviesPlaylists", която съдържа всички 
    /// връзки между филм и плейлистите, в които частва, на приложението.
    /// </summary>
    [Table("MoviesPlaylists")]
    public class MoviePlaylist
    {
        /// <summary>
        /// Номер на плейлиста
        /// </summary>
        public int PlaylistId { get; set; }
        /// <summary>
        /// Плейлист на връзката
        /// </summary>
        public Playlist Playlist { get; set; }
        /// <summary>
        /// Номер на филма
        /// </summary>
        public int MovieId { get; set; }
        /// <summary>
        /// Филм, участващ в плейлиста
        /// </summary>
        public Movie Movie { get; set; }
        /// <summary>
        /// Конструктор на класа
        /// </summary>
        /// <param name="playlistId">Номер на плейлиста</param>
        /// <param name="movieId">Номер на филма</param>
        public MoviePlaylist(int playlistId, int movieId)
        {
            PlaylistId = playlistId;
            MovieId = movieId;
        }
    }
}
