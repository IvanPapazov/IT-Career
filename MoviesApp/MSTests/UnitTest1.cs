using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesApp.Business;
using MoviesApp.Data;
using MoviesApp.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace MSTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
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
        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
        //public void TestGetAllDirectors()
        //{
        //    MovieContext movieContext;
        //    MovieBusiness bc = new MovieBusiness();
        //    using (movieContext = new MovieContext())
        //    {
        //        List<Movie> movies = movieContext.Movies.ToList();
        //        List<Movie> movies1 = bc.GetAllMovies(); 
        //        Assert.
        //        Assert.AreSame(movies, movies1, "Does not return all movie value");
        //    }
        //}
    }
}
