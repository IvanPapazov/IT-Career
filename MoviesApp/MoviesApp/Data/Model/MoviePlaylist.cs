using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MoviesApp.Data.Model
{
    [Table("MoviesPlaylists")]
    public class MoviePlaylist
    {
      
        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }

        public MoviePlaylist(int movieId, int playListId)
        {
            MovieId = movieId;
            PlaylistId = playListId;
        }
    }
}
