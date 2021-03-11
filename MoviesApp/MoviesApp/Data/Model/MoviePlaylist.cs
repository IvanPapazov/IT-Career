using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MoviesApp.Data.Model
{
    [Table("MoviesPlaylists")]
    public class MoviePlaylist
    {

        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        public MoviePlaylist(int playlistId, int movieId)
        {
            PlaylistId = playlistId;
            MovieId = movieId;
        }
    }
}
