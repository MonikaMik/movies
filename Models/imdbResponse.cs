using System;
namespace MoviePage.Models
{
    public class imdbResponse
    {
        public string Metascore { get; set; }
        public string imdbRating { get; set; }
        public string imdbVotes { get; set; }
        public string Year { get; set; }
        public string Runtime { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public Rating[] Ratings { get; set; }
    }
    public class Rating
    {
        public string Source { get; set; }
        public string Value { get; set; }
    }
}
