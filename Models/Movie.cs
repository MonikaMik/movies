using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MoviePage.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext()
        {
        }

        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        { }

        public DbSet<Movie> Movies { get; set; }
    }

    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public double? MonikaScore { get; set; }
        public double? RytisScore { get; set; }
        [NotMapped]
        public string Imdb { get; set; }
        [NotMapped]
        public string Votes { get; set; }
        [NotMapped]
        public string MetaScore { get; set; }
        [NotMapped]
        public string Year { get; set; }
        [NotMapped]
        public string Runtime { get; set; }
        [NotMapped]
        public string Director { get; set; }
        [NotMapped]
        public string Actors { get; set; }
        [NotMapped]
        public string Plot { get; set; }
        [NotMapped]
        public string Poster { get; set; }
        [NotMapped]
        public string RottenTomatoes { get; set; }
        [NotMapped]
        public string Color { get; set; }
    }
}
