using MoviesApp.Business;
using MoviesApp.Data;
using MoviesApp.Data.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTest1
{
    public class Tests
    {
        [Test]
        public void TestGetMovie()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            using (movieContext = new MovieContext())
            {
                Movie movie = movieContext.Movies.Find(2);
                Assert.AreEqual(movie.MovieTitle, bc.GetMovie(2).MovieTitle, "Does not return a movie value");
            }
        }
        [Test]
        public void TestGetActor()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            using (movieContext = new MovieContext())
            {
                Actor actor = movieContext.Actors.Find(2);
                Assert.AreEqual((actor.FirstName, actor.LastName), (bc.GetActor(2).FirstName, bc.GetActor(2).LastName), "Does not return a actor value");
            }
        }
        [Test]
        public void TestGetGenre()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            using (movieContext = new MovieContext())
            {
                Genre genre = movieContext.Genres.Find(2);
                Assert.AreEqual(genre.Title, bc.GetGenre(2).Title, "Does not return a genre value");
            }
        }
        [Test]
        public void TestGetDirector()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            using (movieContext = new MovieContext())
            {
                Director director = movieContext.Directors.Find(2);
                Assert.AreEqual((director.FirstName, director.LastName), (bc.GetDirector(2).FirstName, bc.GetDirector(2).LastName), "Does not return a director value");
            }
        }
        [Test]
        public void TestGetPlaylist()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            using (movieContext = new MovieContext())
            {
                Playlist playlist = movieContext.Playlists.Find(2);
                Assert.AreEqual(playlist.Name, bc.GetPlaylist(2).Name, "Does not return a Playlist value");
            }
        }
        [Test]
        public void TestGetAllMovies()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            using (movieContext = new MovieContext())
            {
                List<Movie> movies = movieContext.Movies.ToList();
                List<Movie> movies1 = bc.GetAllMovies();
                Assert.AreEqual(movies.Count, movies1.Count, "Does not return all movie value");
            }
        }
        [Test]
        public void TestGetAllDirectors()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            using (movieContext = new MovieContext())
            {
                List<Director> directors = movieContext.Directors.ToList();
                List<Director> directors1 = bc.GetAllDirectors();
                Assert.AreEqual(directors.Count, directors1.Count, "Does not return all director value");
            }
        }
        [Test]
        public void TestGetAllActors()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            using (movieContext = new MovieContext())
            {
                List<Actor> actors = movieContext.Actors.ToList();
                List<Actor> actors1 = bc.GetAllActors();             
                Assert.AreEqual(actors.Count, actors1.Count, "Does not return all actor value");
            }
        }
        [Test]
        public void TestGetAllGenres()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            using (movieContext = new MovieContext())
            {
                List<Genre> genres = movieContext.Genres.ToList();
                List<Genre> genres1 = bc.GetAllGenres();
                Assert.AreEqual(genres.Count, genres1.Count, "Does not return all genres value");
            }
        }
        [Test]
        public void TestGetAllPlaylists()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            using (movieContext = new MovieContext())
            {
                List<Playlist> playlists = movieContext.Playlists.ToList();
                List<Playlist> playlists1 = bc.GetAllPlaylists();
                Assert.AreEqual(playlists.Count, playlists1.Count, "Does not return all playlists value");
            }
        }
        [Test]
        public void TestAddMovie()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            List<Movie> movies = bc.GetAllMovies();
            Movie movie = new Movie("AAAA", 2000, 133, "US", 1, "ASDFD");
            bc.Add(movie);
            List<Movie> movies1 = bc.GetAllMovies();
            using (movieContext = new MovieContext())
            {
                movieContext.Movies.Remove(movie);
            }
            Assert.AreNotSame(movies, movies1, "Not added movie in Movies");
        }
        [Test]
        public void TestAddActor()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            List<Actor> actors = bc.GetAllActors();
            Actor actor = new Actor("Zak", "Efron", "male");
            bc.Add(actor);
            List<Actor> actors1 = bc.GetAllActors();
            using (movieContext = new MovieContext())
            {
                movieContext.Actors.Remove(actor);
            }
            Assert.AreNotSame(actors, actors1, "Not added actor in Actors");
        }
        [Test]
        public void TestAddGenre()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            List<Genre> genres = bc.GetAllGenres();
            Genre genre = new Genre("ASD");
            bc.Add(genre);
            List<Genre> genres1 = bc.GetAllGenres();
            using (movieContext = new MovieContext())
            {
                movieContext.Genres.Remove(genre);
            }
            Assert.AreNotSame(genres, genres1, "Not added genre in Genres");
        }
        [Test]
        public void TestAddDirector()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            List<Director> directors = bc.GetAllDirectors();
            Director director = new Director("Petur", "Kirilov");
            bc.Add(director);
            List<Director> directors1 = bc.GetAllDirectors();
            using (movieContext = new MovieContext())
            {
                movieContext.Directors.Remove(director);
            }
            Assert.AreNotSame(directors, directors1, "Not added director in Directors");
        }
        [Test]
        public void TestAddPlaylist()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            List<Playlist> playlists = bc.GetAllPlaylists();
            Playlist playlist = new Playlist("Pop");
            bc.Add(playlist);
            List<Playlist> playlists1 = bc.GetAllPlaylists();
            using (movieContext = new MovieContext())
            {
                movieContext.Playlists.Remove(playlist);
            }
            Assert.AreNotSame(playlists, playlists1, "Not added playlist in Playlist");
        }

        [Test]
        public void TestAddMoviePlaylist()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            using (movieContext = new MovieContext())
            {
                int countMoviePlaylist = movieContext.MoviesPlaylists.Count();
                Movie movie = new Movie("AAAA", 2000, 133, "US", 1, "ASDFD");
                bc.Add(movie);
                Playlist playlist = new Playlist("Pop");
                bc.Add(playlist);
                MoviePlaylist moviePlaylist = new MoviePlaylist(playlist.Id, movie.Id);
                bc.Add(moviePlaylist);
                movieContext.Movies.Remove(movie);
                movieContext.Playlists.Remove(playlist);
                movieContext.MoviesPlaylists.Remove(moviePlaylist);
                int countMoviePlaylist1 = movieContext.MoviesPlaylists.Count();
                Assert.AreNotSame(countMoviePlaylist, countMoviePlaylist1, "Not added value in MoviePlaylist");
            }
        }
        [Test]
        public void TestAddMovieGenre()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            using (movieContext = new MovieContext())
            {

                int countMovieGenre = movieContext.MoviesGenres.Count();
                Movie movie = new Movie("AAAA", 2000, 133, "US", 1, "ASDFD");
                bc.Add(movie);
                Genre genre = new Genre("ASD");
                bc.Add(genre);
                MovieGenre movieGenre = new MovieGenre(movie.Id, genre.Id);
                bc.Add(movieGenre);
                int countMovieGenre1 = movieContext.MoviesGenres.Count();
                movieContext.Movies.Remove(movie);
                movieContext.Genres.Remove(genre);
                movieContext.MoviesGenres.Remove(movieGenre);
                Assert.AreNotSame(countMovieGenre, countMovieGenre1, "Not added value in MovieGenre");
            }
        }
        [Test]
        public void TestAddMovieActor()
        {
            MovieContext movieContext;
            MovieBusiness bc = new MovieBusiness();
            using (movieContext = new MovieContext())
            {
                int countMovieActore = movieContext.MoviesActors.Count();
                Movie movie = new Movie("AAAA", 2000, 133, "US", 1, "ASDFD");
                bc.Add(movie);
                Actor actor = new Actor("Zak", "Efron", "male");
                bc.Add(actor);
                MovieActor movieActor = new MovieActor(movie.Id, actor.Id);
                bc.Add(movieActor);
                int countMovieActore1 = movieContext.MoviesActors.Count();
                movieContext.Movies.Remove(movie);
                movieContext.Actors.Remove(actor);
                movieContext.MoviesActors.Remove(movieActor);
                Assert.AreNotSame(countMovieActore, countMovieActore1, "Not added value in MovieActor");
            }
        }

    }
}