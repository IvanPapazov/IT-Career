using System.Collections.Generic;
using MoviesApp.Data;
using MoviesApp.Data.Model;
using System.Linq;

namespace MoviesApp.Business
{
    class MovieBusiness
    {
        private MovieContext movieContext;
        public bool CheckIsFulled()
        {
            using (movieContext = new MovieContext())
            {
                if (!movieContext.Movies.Any())
                {
                    return false;
                }
                return true;
            }
        }
        public List<Movie> GetAllMovies()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Movies.ToList();
            }
        } 
        public List<Actor> GetAllActors()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Actors.ToList();
            }
        }
        public List<Director> GetAllDirectors()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Directors.ToList();
            }
        } 
        public Movie GetMovie(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Movies.Find(id);
            }
        }
        public Actor GetActor(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Actors.Find(id);
            }
        }
        public Director GetDirector(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Directors.Find(id);
            }
        }
        public void Add(object obj)
        {
            using (movieContext = new MovieContext())
            {
                if (obj.GetType() == typeof(Movie))
                {
                    movieContext.Movies.Add((Movie)obj);
                    movieContext.SaveChanges();
                }
                else if (obj.GetType() == typeof(Actor))
                {
                    movieContext.Actors.Add((Actor)obj);
                    movieContext.SaveChanges();
                }
                else if (obj.GetType() == typeof(MovieActor))
                {
                    movieContext.MoviesActors.Add((MovieActor)obj);
                    movieContext.SaveChanges();
                }
                else if (obj.GetType() == typeof(Genre))
                {
                    movieContext.Genres.Add((Genre)obj);
                    movieContext.SaveChanges();
                }
                else if (obj.GetType() == typeof(MovieGenre))
                {
                    movieContext.MoviesGenres.Add((MovieGenre)obj);
                    movieContext.SaveChanges();
                }
                else if (obj.GetType() == typeof(Playlist))
                {
                    movieContext.Playlists.Add((Playlist)obj);
                    movieContext.SaveChanges();
                }
                else if (obj.GetType() == typeof(MoviePlaylist))
                {
                    movieContext.MoviesPlaylists.Add((MoviePlaylist)obj);
                    movieContext.SaveChanges();
                }
                else if (obj.GetType() == typeof(Director))
                {
                    movieContext.Directors.Add((Director)obj);
                    movieContext.SaveChanges();
                }
            }
        } 
        public void UpdatePlaylistName(Playlist playlist)
        {
            using (movieContext = new MovieContext())
            {
                Playlist item = movieContext.Playlists.Find(playlist.Id);
                if (item != null)
                {
                    movieContext.Entry(item).CurrentValues.SetValues(playlist);
                    movieContext.SaveChanges();
                }
            }
        }
        public void UpdateLike(Movie movie)
        {
            using (movieContext = new MovieContext())
            {
                Movie item = movieContext.Movies.Find(movie.Id);
                if (item != null)
                {
                    //movieContext.Entry(item).CurrentValues.SetValues(movie);
                    item.IsLiked = true;
                    movieContext.SaveChanges();
                }
            }
        }
        public void DeleteFilmFromPlaylist(int playListId, int movieId)
        {
            using (movieContext = new MovieContext())
            {
                Playlist playlist = movieContext.Playlists.Find(playListId);
                Movie movie = movieContext.Movies.Find(movieId);
                if (playlist != null && movie != null)
                {
                    foreach (var playListMovie in movieContext.MoviesPlaylists)
                    {
                        if (playListMovie.PlaylistId == playListId && playListMovie.MovieId == movieId)
                        {
                            movieContext.MoviesPlaylists.Remove(playListMovie);
                            movieContext.SaveChanges();
                            break;
                        }
                    }
                }
            }
        }
    }
}
