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
        MovieContext movieContext;
        MovieBusiness bc = new MovieBusiness();

        [Test]
        public void TestGetMovie()
        {  
            using (movieContext = new MovieContext())
            {
                Movie movie = movieContext.Movies.Find(2);
                Assert.AreEqual(movie.MovieTitle, bc.GetMovie(2).MovieTitle, "Does not return a movie value");
            }
        }
        [Test]
        public void TestGetActor()
        {
            using (movieContext = new MovieContext())
            {
                Actor actor = movieContext.Actors.Find(2);
                Assert.AreEqual((actor.FirstName, actor.LastName), (bc.GetActor(2).FirstName, bc.GetActor(2).LastName), "Does not return a actor value");
            }
        }
        [Test]
        public void TestGetGenre()
        {     
            using (movieContext = new MovieContext())
            {
                Genre genre = movieContext.Genres.Find(2);
                Assert.AreEqual(genre.Title, bc.GetGenre(2).Title, "Does not return a genre value");
            }
        }
        [Test]
        public void TestGetDirector()
        {
            using (movieContext = new MovieContext())
            {
                Director director = movieContext.Directors.Find(2);
                Assert.AreEqual((director.FirstName, director.LastName), (bc.GetDirector(2).FirstName, bc.GetDirector(2).LastName), "Does not return a director value");
            }
        }
        [Test]
        public void TestGetPlaylist()
        {
            using (movieContext = new MovieContext())
            {
                Playlist playlist = movieContext.Playlists.Find(1);
                Assert.AreEqual(playlist.Name, bc.GetPlaylist(1).Name, "Does not return a Playlist value");
            }
        }
        [Test]
        public void TestGetAllMovies()
        {
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
            List<Movie> movies = bc.GetAllMovies();
            Movie movie = new Movie("AAAA", 2000, 133, "US", 1, "ASDFD");
            bc.Add(movie);
            List<Movie> movies1 = bc.GetAllMovies();
            using (movieContext = new MovieContext())
            {
                movieContext.Movies.Remove(movie);
                movieContext.SaveChanges();
            }
            Assert.AreNotEqual(movies, movies1, "Not added movie in Movies");
        }
        [Test]
        public void TestAddActor()
        {
            List<Actor> actors = bc.GetAllActors();
            Actor actor = new Actor("Zak", "Efron", "male");
            bc.Add(actor);
            List<Actor> actors1 = bc.GetAllActors();
            using (movieContext = new MovieContext())
            {
                movieContext.Actors.Remove(actor);
                movieContext.SaveChanges();
            }
            Assert.AreNotEqual(actors, actors1, "Not added actor in Actors");
        }
        [Test]
        public void TestAddGenre()
        {
            List<Genre> genres = bc.GetAllGenres();
            Genre genre = new Genre("ASD");
            bc.Add(genre);
            List<Genre> genres1 = bc.GetAllGenres();
            using (movieContext = new MovieContext())
            {
                movieContext.Genres.Remove(genre);
                movieContext.SaveChanges();
            }
            Assert.AreNotEqual(genres, genres1, "Not added genre in Genres");
        }
        [Test]
        public void TestAddDirector()
        {
            List<Director> directors = bc.GetAllDirectors();
            Director director = new Director("Petur", "Kirilov");
            bc.Add(director);
            List<Director> directors1 = bc.GetAllDirectors();
            using (movieContext = new MovieContext())
            {
                movieContext.Directors.Remove(director);
                movieContext.SaveChanges();
            }
            Assert.AreNotEqual(directors, directors1, "Not added director in Directors");
        }
        [Test]
        public void TestAddMovieGenre()
        {
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
                movieContext.SaveChanges();
                Assert.AreNotEqual(countMovieGenre, countMovieGenre1, "Not added value in MovieGenre");
            }
        }
        [Test]
        public void TestAddMovieActor()
        {
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
                movieContext.SaveChanges();
                Assert.AreNotEqual(countMovieActore, countMovieActore1, "Not added value in MovieActor");
            }
        }
        [Test]
        public void CheckIsFulledReturTrue()
        {
            using (movieContext = new MovieContext())
            {
                bool isFulled = movieContext.Movies.Any();
                Assert.AreEqual(isFulled, bc.CheckIsFulled(), "Database is not created");
            }
        }
        [Test]
        public void DeleteMovieFromPlaylist()
        {
            using (movieContext = new MovieContext())
            {
                //Playlist playlist = new Playlist("AROWwwf");
                //bc.Add(playlist);
                Movie movie = new Movie("AAAA", 2000, 133, "US", 1, "ASDFD");
                bc.Add(movie);
                MoviePlaylist moviePlaylist = new MoviePlaylist(1, movie.Id);
                bc.Add(moviePlaylist);
                int playlistMovieCountBeforeDeleted = movieContext.MoviesPlaylists.Count();
                bc.DeleteMovieFromPlaylist(1, bc.GetMovie(movie.Id).Id);
                movieContext.Movies.Remove(bc.GetMovie(movie.Id));
                movieContext.SaveChanges();
                int playlistMovieCountAfterDeleted = movieContext.MoviesPlaylists.Count();
                Assert.AreNotEqual(playlistMovieCountAfterDeleted, playlistMovieCountBeforeDeleted, "�he  movie in playlist is not deleted");
            }
        }
        [Test]
        public void UpdateLike()
        {
            using (movieContext = new MovieContext())
            {
                Movie movie = new Movie("AAAA", 2000, 133, "US", 1, "ASDFD");
                bc.Add(movie);
                bc.UpdateLike(movie);
                bool isTrue = bc.GetMovie(movie.Id).IsLiked;
                movieContext.Movies.Remove(movie);
                movieContext.SaveChanges();
                Assert.IsTrue(isTrue, "�he like is not updated");
            }
        }
        [Test]
        public void UpdateDislike()
        {
            using (movieContext = new MovieContext())
            {
                Movie movie = new Movie("AAAA", 2000, 133, "US", 1, "ASDFD");
                bc.Add(movie);
                movie.IsLiked = true;
                movieContext.SaveChanges();
                bc.UpdateDislike(movie);
                bool isFalse = bc.GetMovie(movie.Id).IsLiked;
                movieContext.Movies.Remove(movie);
                movieContext.SaveChanges();
                Assert.IsFalse(isFalse, "�he dislike is not updated");
            }
        }
        [Test]
        public void TestAddPlaylist()
        {
            List<Playlist> playlists = bc.GetAllPlaylists();
            Playlist playlist = new Playlist("Pop");
            bc.Add(playlist);
            List<Playlist> playlists1 = bc.GetAllPlaylists();
            using (movieContext = new MovieContext())
            {
                movieContext.Playlists.Remove(playlist);
                movieContext.SaveChanges();
            }
            Assert.AreNotEqual(playlists, playlists1, "Not added playlist in Playlist");
        }
        [Test]
        public void TestAddMoviePlaylist()
        {
            using (movieContext = new MovieContext())
            {
                int countMoviePlaylist = movieContext.MoviesPlaylists.Count();
                Movie movie = new Movie("AAAA", 2000, 133, "US", 1, "ASDFD");
                bc.Add(movie);
                Playlist playlist = new Playlist("Pop");
                bc.Add(playlist);
                MoviePlaylist moviePlaylist = new MoviePlaylist(playlist.Id, movie.Id);
                bc.Add(moviePlaylist);
                int countMoviePlaylist1 = movieContext.MoviesPlaylists.Count();
                movieContext.Movies.Remove(movie);
                movieContext.Playlists.Remove(playlist);
                movieContext.MoviesPlaylists.Remove(moviePlaylist);
                movieContext.SaveChanges();
                Assert.AreNotEqual(countMoviePlaylist, countMoviePlaylist1, "Not added value in MoviePlaylist");
            }
        }

    }
}