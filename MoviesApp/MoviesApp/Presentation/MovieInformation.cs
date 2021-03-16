using MoviesApp.Data.Model;
using MoviesApp.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesApp.Presentation
{
   public static class MovieInformation
    {
        public static Form1 form1 { get; set; }
        public static FormAction formAction { get; set; }
        public static Film film { get; set; }
        public static Actors actors { get; set; }

        public static int IndexGenre { get; set; }
        public static string GenreLetter { get; set; }
        public static int IndexMovie { get; set; }
        public static string LetterMovie { get; set; }



    }
}
