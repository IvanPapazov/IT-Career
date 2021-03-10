using System.Collections.Generic;
using MoviesApp.Data;
using MoviesApp.Data.Model;
using System.Linq;

namespace MoviesApp.Business
{
    class MovieBusiness
    {
        private MovieContext productContext;
        public bool IsCreated { get; set; }
        public bool IsFulled { get; set; }
        public void CheckIsCreated()
        {
            using (productContext = new MovieContext())
            {
                if (productContext.Exists())
                {
                    this.IsCreated = true;
                }
                else
                {
                    this.IsCreated = false;
                }
            }
        }
        public bool CheckIsFulled()
        {
            using (productContext = new MovieContext())
            {
                if (!productContext.Movies.Any())
                {
                    return false;
                }
                return true;
            }
        }
        public List<Movie> GetAll()
        {
            using (productContext = new MovieContext())
            {
                return productContext.Movies.ToList();
            }
        }

        public Movie GetMovie(int id)
        {
            using (productContext = new MovieContext())
            {
                return productContext.Movies.Find(id);
            }
        }
        public Actor GetActor(int id)
        {
            using (productContext = new MovieContext())
            {
                return productContext.Actors.Find(id);
            }
        }
        public void Add(MovieActor ma)
        {
            using (productContext = new MovieContext())
            {
                productContext.MoviesActors.Add(ma);
                productContext.SaveChanges();
            }
        }
        public void Add(Actor actor)
        {
            using (productContext = new MovieContext())
            {
                productContext.Actors.Add(actor);
                productContext.SaveChanges();
            }
        }
        public void Add(Movie movie)
        {
            using (productContext = new MovieContext())
            {
                productContext.Movies.Add(movie);
                productContext.SaveChanges();
            }
        }
        public void Update(Movie product)
        {
            using (productContext = new MovieContext())
            {
                Movie item = productContext.Movies.Find(product.Id);
                if (item != null)
                {
                    productContext.Entry(item).CurrentValues.SetValues(product);
                    productContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (productContext = new MovieContext())
            {
                Movie product = productContext.Movies.Find(id);
                if (product != null)
                {
                    productContext.Movies.Remove(product);
                    productContext.SaveChanges();
                }
            }
        }
    }
}
