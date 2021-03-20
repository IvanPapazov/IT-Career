using System.Collections.Generic;
using MoviesApp.Data;
using MoviesApp.Data.Model;
using System.Linq;
using MoviesApp.Presentation;
using MoviesApp.Resources;
using System.Windows.Forms;
using System.Drawing;

namespace MoviesApp.Business
{
    /// <summary>
    /// Това е клас който съдържа основната логика в приложението
    /// </summary>
    public class MovieBusiness
    {
        private MovieContext movieContext;
        /// <summary>
        /// Проверява дали базата има записи в нея
        /// </summary>
        /// <returns></returns>
        public bool CheckIsFulled()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Movies.Any();
            }
        }
        /// <summary>
        /// Връща лист от филми
        /// </summary>
        /// <returns></returns>
        public List<Movie> GetAllMovies()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Movies.ToList();
            }
        }
        /// <summary>
        /// Връща лист от актьори
        /// </summary>
        /// <returns></returns>
        public List<Actor> GetAllActors()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Actors.ToList();
            }
        }
        /// <summary>
        /// Връща лист от жанрове
        /// </summary>
        /// <returns></returns>
        public List<Genre> GetAllGenres()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Genres.ToList();
            }
        }
        /// <summary>
        /// Връща лист от плейлисти
        /// </summary>
        /// <returns></returns>
        public List<Playlist> GetAllPlaylists()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Playlists.ToList();
            }
        }
        /// <summary>
        /// Връща лист от режисьори
        /// </summary>
        /// <returns></returns>
        public List<Director> GetAllDirectors()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Directors.ToList();
            }
        }
        /// <summary>
        /// Връща лист от мапинг табличката на филмите и жанровете
        /// </summary>
        /// <returns></returns>
        public List<MovieGenre> GetAllMovieGenre()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.MoviesGenres.ToList();
            }
        }
        /// <summary>
        /// Връща лист от мапинг табличката на филмите и актьорите
        /// </summary>
        /// <returns></returns>
        public List<MovieActor> GetAllMovieActors()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.MoviesActors.ToList();
            }
        }
        /// <summary>
        /// Връща лист от мапинг табличката на филмите и плейлистите
        /// </summary>
        /// <returns></returns>
        public List<MoviePlaylist> GetAllMoviePlaylists()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.MoviesPlaylists.ToList();
            }
        }
        /// <summary>
        /// Връща един филм по дадено Id
        /// </summary>
        /// <param name="id">Идентификационнен номер на филм</param>
        /// <returns></returns>
        public Movie GetMovie(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Movies.Find(id);
            }
        }
        /// <summary>
        /// Връща един актьор по дадено Id
        /// </summary>
        /// <param name="id">Идентификационнен номер на актьор</param>
        /// <returns></returns>
        public Actor GetActor(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Actors.Find(id);
            }
        }
        /// <summary>
        /// Връща един жанр по дадено Id
        /// </summary>
        /// <param name="id">Идентификационнен номер на жанр</param>
        /// <returns></returns>
        public Genre GetGenre(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Genres.Find(id);
            }
        }
        /// <summary>
        /// Връща един плейлист по дадено Id
        /// </summary>
        /// <param name="id">Идентификационнен номер на плейлист</param>
        /// <returns></returns>
        public Playlist GetPlaylist(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Playlists.Find(id);
            }
        }
        /// <summary>
        /// Връща един режисьор по дадено Id
        /// </summary>
        /// <param name="id">Идентификационнен номер на режисьор</param>
        /// <returns></returns>
        public Director GetDirector(int id)
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.Directors.Find(id);
            }
        }
        /// <summary>
        /// Добавя всички данни в базата данни
        /// </summary>
        /// <param name="obj">Типът на информацията която е подадена</param>
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
        /// <summary>
        /// Променя името на плейлиста
        /// </summary>
        /// <param name="playlist">плейлистът на който ще се промени името</param>
        /// <param name="name">името с което ще се промени</param>
        public void UpdatePlaylistName(Playlist playlist, string name)
        {
            using (movieContext = new MovieContext())
            {
                Playlist item = movieContext.Playlists.Find(playlist.Id);
                if (item != null)
                {
                    item.Name = name;
                    movieContext.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Харесва филмът и го добавя към плейлиста любими
        /// </summary>
        /// <param name="movie">филмът който ще бъде харесан</param>
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
        /// <summary>
        /// Отхаресва филмът и го премахва от плейлиста любими
        /// </summary>
        /// <param name="movie">филмът който ще бъде отхаресан</param>
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
        /// <summary>
        /// Изтрива даденият плейлист и неговите връзки
        /// </summary>
        /// <param name="id">Идентификационнен номер на плейлист</param>
        public void DeletePlaylist(int id)
        {
            using (movieContext = new MovieContext())
            {
                Playlist playlist = movieContext.Playlists.Find(id);
                if (playlist != null)
                {
                    foreach (var playListMovie in movieContext.MoviesPlaylists)
                    {
                        if (playListMovie.PlaylistId == id)
                        {
                            movieContext.MoviesPlaylists.Remove(playListMovie);
                            movieContext.SaveChanges();
                        }
                    }
                    movieContext.Playlists.Remove(playlist);
                    movieContext.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Изтрива дадена връзка на филм с плейлист
        /// </summary>
        /// <param name="playListId">Идентификационнен номер на плейлист</param>
        /// <param name="movieId">Идентификационнен номер на филмът</param>
        public void DeleteMovieFromPlaylist(int playListId, int movieId)
        {
            using (movieContext = new MovieContext())
            {
                Playlist playlist = movieContext.Playlists.Find(playListId);
                Movie movie = movieContext.Movies.Find(movieId);
                if (playlist != null && movie != null)
                {
                    foreach (MoviePlaylist playListMovie in movieContext.MoviesPlaylists)
                    {
                        if (playListMovie.PlaylistId == playlist.Id && playListMovie.MovieId == movie.Id)
                        {
                            movieContext.MoviesPlaylists.Remove(playListMovie);
                            break;
                        }
                    }
                }
                movieContext.SaveChanges();
            }
        }
        /// <summary>
        /// Прави връзка в мапинг табличката на филми и жанрове
        /// </summary>
        /// <param name="movieId">Идентификационнен номер на филмът</param>
        /// <param name="genresId">Идентификационнен номер на жанра</param>
        public void MapMovieAndGenre(int movieId, List<int> genresId)
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
        /// <summary>
        /// Връща актьорите които участват в даден филм 
        /// </summary>
        /// <param name="movieId">Идентификационнен номер на филмът</param>
        /// <returns></returns>
        public List<Actor> FindActorsFromMovie(int movieId)
        {
            List<MovieActor> movieActor = GetAllMovieActors().Where(mg => mg.MovieId == movieId).ToList();
            List<Actor> actors = new List<Actor>();

            foreach (var item in movieActor)
            {
                actors.Add(GetActor(item.ActorId));
            }
            return actors;
        }
        /// <summary>
        /// Връща всички филми които са от даден жанр
        /// </summary>
        /// <param name="genreId">Идентификационнен номер на жанра</param>
        /// <returns></returns>
        public List<Movie> FindMoviesFromGenre(int genreId)
        {
            List<MovieGenre> movieGenre = GetAllMovieGenre().Where(mg => mg.GenreId == genreId).ToList();
            List<Movie> movies = new List<Movie>();

            foreach (var item in movieGenre)
            {
                movies.Add(GetMovie(item.MovieId));
            }
            return movies;
        }
        /// <summary>
        /// Връща всички жанрове на даден филм
        /// </summary>
        /// <param name="movieId">Идентификационнен номер на филма</param>
        /// <returns></returns>
        public List<Genre> FindGenresOfMovie(int movieId)
        {
            Movie movie = GetMovie(movieId);
            List<MovieGenre> movieGenres = GetAllMovieGenre();

            List<Genre> genres = new List<Genre>();

            if (movie != null)
            {
                foreach (var genre in movieGenres)
                {
                    if (genre.MovieId == movieId)
                    {
                        genres.Add(GetGenre(genre.GenreId));
                    }
                }
            }
            return genres;
        }
        /// <summary>
        /// Добавя актьорите и прави връзки в мапинг табличките при добавянето на нов филм
        /// </summary>
        /// <param name="actorList">Всички актьори които ще трябва да добави</param>
        /// <param name="idMovie">Идентификационният номер на новият филм</param>
        public void AddActorsForMovie(List<string> actorList, int idMovie)
        {
            foreach (var actorString in actorList)
            {
                int idActor = 0;
                using (movieContext = new MovieContext())
                {
                    string actorFirstName = actorString.Split(" ")[0];
                    string actorLastName = actorString.Split(" ")[1];
                    string actorGender = actorString.Split(" ")[2];
                    List<Actor> actors = GetAllActors();
                    for (int i = 0; i < actors.Count; i++)
                    {
                        Actor actor = actors[i];
                        if (actor.FirstName == actorFirstName && actor.LastName == actorLastName && actor.Gender == actorGender)
                        {
                            idActor = actor.Id;

                            MovieActor movieActor = new MovieActor(idMovie, idActor);
                            Add(movieActor);
                            break;
                        }
                    }
                    if (idActor == 0)
                    {
                        Actor actor = new Actor(actorFirstName, actorLastName, actorGender);
                        Add(actor);

                        idActor = actor.Id;
                        MovieActor movieActor = new MovieActor(idMovie, idActor);
                        Add(movieActor);
                    }
                }
            }
        }
        /// <summary>
        /// Прави връзки в мапинг табличката на филми и жанрове при добавянето на нов филм
        /// </summary>
        /// <param name="genreList">жанровете с които ще прави връзки</param>
        /// <param name="idMovie">Идентификационният номер на новият филм</param>
        public void AddGenreForMovie(List<string> genreList, int idMovie)
        {
            foreach (var item in genreList)
            {
                using (movieContext = new MovieContext())
                {
                    string genreName = item;
                    int idGenre = 0;
                    List<Genre> genres = GetAllGenres();
                    for (int i = 0; i < genres.Count; i++)
                    {
                        Genre genre = genres[i];
                        if (genre.Title == genreName)
                        {
                            idGenre = genre.Id;

                            MovieGenre movieGenre = new MovieGenre(idMovie, idGenre);
                            Add(movieGenre);
                            break;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Добавя снимка по даден жанр в bin/Debug при добавянето на нов филм
        /// </summary>
        /// <param name="genreList">Жанровете които ще се използват за добавянето на снимката</param>
        /// <param name="data">Снимката която ще се добави</param>
        private void AddImageForMovie(List<string> genreList, object data)
        {
            foreach (var item in genreList)
            {
                string letterMovie = "";
                int indexMovie = 0;
                switch (item)
                {
                    case "Екшън":
                        letterMovie = "A";
                        indexMovie = FindMoviesFromGenre(1).Count;
                        break;
                    case "Приключенски":
                        letterMovie = "Adv";
                        indexMovie = FindMoviesFromGenre(2).Count;
                        break;
                    case "Комедии":
                        letterMovie = "Comedy";
                        indexMovie = FindMoviesFromGenre(3).Count;
                        break;
                    case "Криминални":
                        letterMovie = "Criminal";
                        indexMovie = FindMoviesFromGenre(4).Count;
                        break;
                    case "Фентъзи":
                        letterMovie = "Fantasy";
                        indexMovie = FindMoviesFromGenre(5).Count;
                        break;
                    case "Научна фантастика":
                        letterMovie = "Sci";
                        indexMovie = FindMoviesFromGenre(6).Count;
                        break;
                    case "Исторически":
                        letterMovie = "History";
                        indexMovie = FindMoviesFromGenre(7).Count;
                        break;
                    case "Ужаси":
                        letterMovie = "Horror";
                        indexMovie = FindMoviesFromGenre(8).Count;
                        break;
                    case "Романтика":
                        letterMovie = "Romance";
                        indexMovie = FindMoviesFromGenre(9).Count;
                        break;
                    case "Трилър":
                        letterMovie = "Thriller";
                        indexMovie = FindMoviesFromGenre(10).Count;
                        break;
                    case "Анимация":
                        letterMovie = "Cartoon";
                        indexMovie = FindMoviesFromGenre(11).Count;
                        break;
                    case "Драма":
                        letterMovie = "Drama";
                        indexMovie = FindMoviesFromGenre(12).Count;
                        break;
                }
                if (data != null)
                {
                    var fileName = data as string[];
                    if (fileName.Length > 0)
                    {
                        string location = $"fotos{letterMovie}\\{letterMovie}{indexMovie}.jpg";
                        Bitmap bitmap = (Bitmap)Image.FromFile(fileName[0]);
                        bitmap.Save(location);
                    }
                }
                else
                {
                    string location = $"fotos{letterMovie}\\{letterMovie}{indexMovie}.jpg";
                    Bitmap bitmap = (Bitmap)Image.FromFile("otherResources\\defaultImage.png");
                    bitmap.Save(location);
                }
            }
        }
        /// <summary>
        /// Главният метод който проверява дали филмът вече е добавен във базата данни, проверява дали даденият директор вече съществува в базата данни и прави връзката между довият филм и дииректорът, след което вика останалите методи за да добави и останалите данни за филма
        /// </summary>
        /// <param name="directorString">Името и фамилията на директорът</param>
        /// <param name="actorList">Актьорите които ще бъдат подадени на метода за добавяне на актьори</param>
        /// <param name="genreList">Жанровете които ще бъдат подадени на метода за добавяне на жанрове и на метода за добавяне на снимки по даден жанр</param>
        /// <param name="movieName">Името на филма</param>
        /// <param name="year">Годината на филма</param>
        /// <param name="duration">Времетраенето на филма</param>
        /// <param name="countrie">Държавата на филма</param>
        /// <param name="description">Описанието на филма</param>
        /// <param name="data">Снимката която ще бъдат подадена на метода за добавяне на снимки</param>
        public void AddMovieInDatabase(string[] directorString, List<string> actorList, List<string> genreList, string movieName, int year, int duration, string countrie, string description, object data)
        {
            int idDirector;
            int idMovie;
            using (movieContext = new MovieContext())
            {
                idMovie = 0;
                List<Movie> movies = GetAllMovies();
                for (int i = 0; i < movies.Count; i++)
                {
                    Movie movieFind = movies[i];
                    if (movieFind.MovieTitle == movieName)
                    {
                        string messageContainsMovie = $"Филмът вече съществува";
                        string titleContainsMovie = "";
                        MessageBoxButtons buttonsContainsMovie = MessageBoxButtons.OK;
                        DialogResult resultContainsMovie = MessageBox.Show(messageContainsMovie, titleContainsMovie, buttonsContainsMovie);
                        return;
                    }
                }
            }
            using (movieContext = new MovieContext())
            {
                string directorFirstName = directorString[0];
                string directorLasrName = directorString[1];
                idDirector = 0;
                List<Director> directors = GetAllDirectors();
                for (int i = 0; i < directors.Count; i++)
                {
                    Director director = directors[i];
                    if (director.FirstName == directorFirstName && director.LastName == directorLasrName)
                    {
                        idDirector = director.Id;
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
                if (idDirector != 0)
                {
                    Movie movie = new Movie(movieName, year, duration, countrie, idDirector, description);
                    Add(movie);
                }
                else
                {
                    idDirector = GetAllDirectors().Last().Id;
                    Movie movie = new Movie(movieName, year, duration, countrie, idDirector, description);
                    Add(movie);
                }
            }
            idMovie = GetAllMovies().Last().Id;

            AddActorsForMovie(actorList, idMovie);
            AddGenreForMovie(genreList, idMovie);
            AddImageForMovie(genreList, data);

            string messageAddMovie = $"Филмът е добавен.";
            string titleAddMovie = "";
            MessageBoxButtons buttonsAddMovie = MessageBoxButtons.OK;
            DialogResult resultAddMovie = MessageBox.Show(messageAddMovie, titleAddMovie, buttonsAddMovie);
        }
    }
}
