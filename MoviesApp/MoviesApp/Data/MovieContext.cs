using Microsoft.EntityFrameworkCore;
using MoviesApp.Data.Model;

namespace MoviesApp.Data
{
    /// <summary>
    /// Клас, управляващ връзката между приложението и базата данни.
    /// Наследява "DbContext" идващ от NuGet пакета EntityFrameworkCore
    /// </summary>
    public class MovieContext : DbContext
    {
        /// <summary>
        /// Конструктор на класа
        /// Чрез "Database.EnsureCreated()" се проверява дали базата е създадена и ако не е, се създава база
        /// </summary>
        public MovieContext()
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Таблица с актьори
        /// </summary>
        public DbSet<Actor> Actors { get; set; }
        /// <summary>
        /// Таблица с филми
        /// </summary>
        public DbSet<Movie> Movies { get; set; }
        /// <summary>
        /// Таблица с жанрове
        /// </summary>
        public DbSet<Genre> Genres { get; set; }
        /// <summary>
        /// Таблица с плейлисти
        /// </summary>
        public DbSet<Playlist> Playlists { get; set; }
        /// <summary>
        /// Таблица с режисьори
        /// </summary>
        public DbSet<Director> Directors { get; set; }
        /// <summary>
        /// Таблица с връзки между филми и актьори, участващи в тях
        /// </summary>
        public DbSet<MovieActor> MoviesActors { get; set; }
        /// <summary>
        /// Таблица с връзки между филми и жанровете на всеки филм
        /// </summary>
        public DbSet<MovieGenre> MoviesGenres { get; set; }
        /// <summary>
        /// Таблица с връзки между плейлисти и филми, намиращи се в тях
        /// </summary>
        public DbSet<MoviePlaylist> MoviesPlaylists { get; set; }

        /// <summary>
        /// Обект, нужен за съхраняване на базата на локалния MSSQL Server 
        /// </summary>
        /// <param name="optionsBuilder">Обект, позволяващ свързването със сървъра</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=MovieDb;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /// <summary>
        /// Метод, гарантиращ правилното създаване на връзките между таблиците
        /// </summary>
        /// <param name="modelBuilder">Обект, нужен за моделирането на връзките</param>
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

            //Create a MoviePlaylist mapping table             
            modelBuilder.Entity<MoviePlaylist>().HasKey(mp => new {mp.PlaylistId, mp.MovieId });
          
            modelBuilder.Entity<MoviePlaylist>()
            .HasOne<Playlist>(mp => mp.Playlist)
            .WithMany(p => p.MoviesPlaylists)
            .HasForeignKey(mp => mp.PlaylistId);

            modelBuilder.Entity<MoviePlaylist>()
            .HasOne<Movie>(mp => mp.Movie)
            .WithMany(m => m.MoviesPlaylists)
            .HasForeignKey(mp => mp.MovieId);

            // Create a Director-Movie relationship
            modelBuilder.Entity<Movie>()
            .HasOne<Director>(m => m.Director)
            .WithMany(d => d.Movies)
            .HasForeignKey(m => m.DirectorId);
        }
    }
}
