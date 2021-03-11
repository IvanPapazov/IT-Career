using Microsoft.EntityFrameworkCore;
using MoviesApp.Data.Model;

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
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<MovieActor> MoviesActors { get; set; }
        public DbSet<MovieGenre> MoviesGenres { get; set; }
        public DbSet<MoviePlaylist> MoviesPlaylists { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=MovieDb;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Create a MovieActor mapping table
            modelBuilder.Entity<MovieActor>().HasKey(ma => new { ma.MovieId, ma.ActorId });

            modelBuilder.Entity<MovieActor>()
            .HasOne<Movie>(ma => ma.Movie)
            .WithMany(m => m.MoviesActors)
            .HasForeignKey(ma => ma.MovieId);

            modelBuilder.Entity<MovieActor>()
            .HasOne<Actor>(ma => ma.Actor)
            .WithMany(a => a.MoviesActors)
            .HasForeignKey(ma => ma.ActorId);

            //Create a MovieGenre mapping table
            modelBuilder.Entity<MovieGenre>().HasKey(mg => new { mg.MovieId, mg.GenreId });

            modelBuilder.Entity<MovieGenre>()
            .HasOne<Movie>(mg => mg.Movie)
            .WithMany(m => m.MoviesGenres)
            .HasForeignKey(mg => mg.MovieId);

            modelBuilder.Entity<MovieGenre>()
            .HasOne<Genre>(mg => mg.Genre)
            .WithMany(a => a.MoviesGenres)
            .HasForeignKey(mg => mg.GenreId);

            //Create a MoviePlaylist mapping table              To do
            modelBuilder.Entity<MovieGenre>().HasKey(mp => new { mp.MovieId, mp.GenreId});

            modelBuilder.Entity<MovieGenre>()
            .HasOne<Movie>(mp => mp.Movie)
            .WithMany(m => m.MoviesGenres)
            .HasForeignKey(mp => mp.MovieId);

            modelBuilder.Entity<MovieGenre>()
            .HasOne<Genre>(mp => mp.Genre)
            .WithMany(a => a.MoviesGenres)
            .HasForeignKey(mp => mp.GenreId);
        }
    }
}
