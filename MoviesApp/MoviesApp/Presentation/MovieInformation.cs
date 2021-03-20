using MoviesApp.Data.Model;
using MoviesApp.Resources;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace MoviesApp.Presentation
{
    /// <summary>
    /// Клас, пазещ информация за основните белези на отделен филм, използвани от различни класове
    /// </summary>
   public static class MovieInformation
    {
        /// <summary>
        /// Обект от форма 1, пазещ информация за нея
        /// </summary>
        public static Form1 form1 { get; set; }

        /// <summary>
        /// Обект от форма Действие, пазещ информация за нея
        /// </summary>
        public static FormAction formAction { get; set; }

        /// <summary>
        /// Обект от форма Филм, пазещ информация за нея
        /// </summary>
        public static Film film { get; set; }

        /// <summary>
        /// Обект от форма Актьори, пазещ информация за нея
        /// </summary>
        public static Actors actors { get; set; }

        /// <summary>
        /// Индекс на жанра на група филми
        /// </summary>
        public static int IndexGenre { get; set; }

        /// <summary>
        /// Съкращение на името на жанр филми
        /// </summary>
        public static string GenreLetter { get; set; }

        /// <summary>
        /// Индекс на определен филм, слушещ ни за търсене на изображение, свързано с филма
        /// </summary>
        public static int IndexMovie { get; set; }

        /// <summary>
        /// Съкращение на жанра на даден филм, служещо ни за търсене на изображение, свързано с филма
        /// </summary>
        public static string LetterMovie { get; set; }

        /// <summary>
        /// Променлива, свързана с името на жанра на определен филм
        /// </summary>
        public static string GenreName { get; set; }



    }
}
