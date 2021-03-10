using Microsoft.EntityFrameworkCore;
using MoviesApp.Data.Model;
using MoviesApp.Business;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace MoviesApp.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieActor> MoviesActors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=MovieDb;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActor>().HasKey(ma => new { ma.MovieId, ma.ActorId });

            modelBuilder.Entity<MovieActor>()
            .HasOne<Movie>(ma => ma.Movie)
            .WithMany(m => m.MoviesActors)
            .HasForeignKey(ma => ma.MovieId);

            modelBuilder.Entity<MovieActor>()
            .HasOne<Actor>(ma => ma.Actor)
            .WithMany(a => a.MoviesActors)
            .HasForeignKey(ma => ma.ActorId);
        }

        public bool Exists()
        {
            return (this.Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists();
        }
    }
}
