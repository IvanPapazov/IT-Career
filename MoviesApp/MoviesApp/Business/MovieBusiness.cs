using System.Collections.Generic;
using MoviesApp.Data;
using MoviesApp.Data.Model;
using System.Linq;

namespace MoviesApp.Business
{
    public class MovieBusiness
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
        public List<Genre> GetAllGenres()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Genres.ToList();
            }
        }
        public List<Playlist> GetAllPlaylists()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Playlists.ToList();
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
        public Genre GetGenre(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Genres.Find(id);
            }
        }
        public Playlist GetPlaylist(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Playlists.Find(id);
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
                    item.IsLiked = true;
                    movieContext.SaveChanges();
                }
            }
        }
        public void UpdateDislike(Movie movie)
        {
            using (movieContext = new MovieContext())
            {
                Movie item = movieContext.Movies.Find(movie.Id);
                if (item != null)
                {
                    item.IsLiked = false;
                    movieContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (movieContext = new MovieContext())
            {
                Playlist playlist = movieContext.Playlists.Find(id);
                if (playlist != null)
                {
                    // delete the records in the mapping table
                    foreach (var playListMovie in movieContext.MoviesPlaylists)
                    {
                        if (playListMovie.PlaylistId == id)
                        {
                            movieContext.MoviesPlaylists.Remove(playListMovie);
                            movieContext.SaveChanges();
                        }
                    }
                    // delete the record in Playlists
                    movieContext.Playlists.Remove(playlist);
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
        public void AddMovieInDatabase(string directorString, List<string> actorList, List<string> genreList, string movieName, int year, int duration, string countrie, string description)
        {
            int idDirector;
            int idMovie;
            using (movieContext = new MovieContext())
            {
                idMovie = 0;
                int countMovies = movieContext.Movies.Count();
                // Check movie exist
                for (int i = 1; i <= countMovies; i++)
                {
                    Movie movieFind = GetMovie(i);
                    if (movieFind.MovieTitle == movieName)
                    {
                        return;
                    }
                }
                idMovie = countMovies + 1;
            }
            using (movieContext = new MovieContext())
            {
                // find or adding director
                string directorFirstName = directorString.Split(" ")[0];
                string directorLasrName = directorString.Split(" ")[1];
                idDirector = 0;
                int countDirectors = movieContext.Directors.Count();
                for (int i = 1; i <= countDirectors; i++)
                {
                    Director director = GetDirector(i);
                    if (director.FirstName == directorFirstName && director.LastName == directorLasrName)
                    {
                        idDirector = i;
                        break;
                    }
                }
                if (idDirector == 0)
                {
                    Director director = new Director(directorFirstName, directorLasrName);

                    Add(director);
                }
            }
            using (movieContext = new MovieContext())
            {
                // Add movie 
                idDirector = movieContext.Directors.Count();
                Movie movie = new Movie(movieName, year, duration, countrie, idDirector, description);
                Add(movie);
            }
            // find or adding actors
            foreach (var actorString in actorList)
            {
                int idActor = 0;
                using (movieContext = new MovieContext())
                {
                    string actorFirstName = actorString.Split(" ")[0];
                    string actorLastName = actorString.Split(" ")[1];
                    string actorGender = actorString.Split(" ")[2];
                    int countActor = movieContext.Actors.Count();
                    for (int i = 1; i <= countActor; i++)
                    {
                        Actor actor = GetActor(i);
                        if (actor.FirstName == actorFirstName && actor.LastName == actorLastName)
                        {
                            idActor = i;

                            // add value in MovieActor
                            MovieActor movieActor = new MovieActor(idMovie, idActor);
                            Add(movieActor);
                            break;
                        }
                    }
                    if (idActor == 0)
                    {
                        //add actor
                        Actor actor = new Actor(actorFirstName, actorLastName, actorGender);
                        Add(actor);

                        // add value in MovieActor
                        idActor = countActor + 1;
                        MovieActor movieActor = new MovieActor(idMovie, idActor);
                        Add(movieActor);
                    }
                }
            }
            //find or adding genre
            foreach (var item in genreList)
            {
                using (movieContext = new MovieContext())
                {
                    string genreName = item;
                    int idGenre = 0;
                    int countGenre = movieContext.Genres.Count();
                    for (int i = 1; i <= countGenre; i++)
                    {
                        Genre genre = GetGenre(i);
                        if (genre.Title == genreName)
                        {
                            idGenre = i;

                            //add value in MovieGenre
                            MovieGenre movieGenre = new MovieGenre(idMovie, idGenre);
                            Add(movieGenre);
                            break;
                        }
                    }
                    if (idGenre == 0)
                    {
                        //add genre
                        Genre genre = new Genre(genreName);
                        Add(genre);
                        //add value in MovieGenre
                        idGenre = countGenre + 1;
                        MovieGenre movieGenre = new MovieGenre(idMovie, idGenre);
                        Add(movieGenre);
                    }
                }
            }
        }
    }
}
