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
        } // petar
        public List<Actor> GetAllActors()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Actors.ToList();
            }
        } // petar

        public List<Genre> GetAllGenres()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Genres.ToList();
            }
        } // ivan
        public List<Playlist> GetAllPlaylists()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Playlists.ToList();
            }
        } // ivan

        public List<Director> GetAllDirectors()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Directors.ToList();
            }
        } // dani

        public List<MovieGenre> GetAllMovieGenre()//Dani
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.MoviesGenres.ToList();
            }
        }
        public List<MovieActor> GetAllMovieActors()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.MoviesActors.ToList();
            }
        }//Dani


        public Movie GetMovie(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Movies.Find(id);
            }
        } // petar
        public Actor GetActor(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Actors.Find(id);
            }
        } // petar

        public Genre GetGenre(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Genres.Find(id);
            }
        } // ivan

        public Playlist GetPlaylist(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Playlists.Find(id);
            }
        } // ivan


        public Director GetDirector(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Directors.Find(id);
            }
        } // dani
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
        } // dani
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
        } //petar
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
        } // petar
        public void UpdateDislike(Movie movie)
        {
            using (movieContext = new MovieContext())
            {
                Movie item = movieContext.Movies.Find(movie.Id);
                if (item != null)
                {
                    //movieContext.Entry(item).CurrentValues.SetValues(movie);
                    item.IsLiked = false;
                    movieContext.SaveChanges();
                }
            }
        } // ivan
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
        } // ivan
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
        } // petar       

        //public void MapMovieAndActor(Movie movie, List<Actor> actors)
        //{
        //    using (movieContext = new MovieContext())
        //    {
        //        foreach (var actor in actors)
        //        {
        //            MovieActor movieActor = new MovieActor(movie.Id, actor.Id);
        //            Add(movieActor);
        //        }            
        //    }
        //}

        public void MapMovieAndGenre(int movieId, List<int> genresId) // yes
        {
            using (movieContext = new MovieContext())
            {
                foreach (var genreId in genresId)
                {
                    MovieGenre movieGenre = new MovieGenre(movieId, genreId);
                    Add(movieGenre);
                }

            }
        }

        //public void MapMovieAndPlayList(Movie movie, Playlist playlist)
        //{
        //    using (movieContext = new MovieContext())
        //    {
        //        MoviePlaylist moviePlaylist = new MoviePlaylist(playlist.Id, movie.Id);
        //        Add(moviePlaylist);
        //    }
        //} // no so far

        public void AddActorsInMovie(List<string> actorList, int idMovie) // yes
        {
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
        }

        public List<Actor> FindActorsFromMovie(int movieId)
        {
            MovieBusiness bc = new MovieBusiness();
            List<MovieActor> movieActor = bc.GetAllMovieActors().Where(mg => mg.MovieId == movieId).ToList();
            List<Actor> actors = new List<Actor>();

            foreach (var item in movieActor)
            {
                actors.Add(bc.GetActor(item.ActorId));
            }
            return actors;
        }
        public List<Movie> FindMoviesFromGenre(int genreId)
        {
            MovieBusiness bc = new MovieBusiness();
            List<MovieGenre> movieGenre = bc.GetAllMovieGenre().Where(mg => mg.GenreId == genreId).ToList();
            List<Movie> movies = new List<Movie>();

            foreach (var item in movieGenre)
            {
                movies.Add(bc.GetMovie(item.MovieId));
            }
            return movies;
        }
    }
}
