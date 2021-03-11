using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesApp.Data.Model
{
    [Table("Playlists")]
    public class Playlist
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IList<MoviePlaylist> MoviesPlaylists { get; set; }
        public Playlist(string name)
        {
            Name = name;
        }
    }
}
