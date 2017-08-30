using System;
using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Movie
    {
        public Movie()
        {
            MovieActors = new HashSet<MovieActor>();
            MovieCountries = new HashSet<MovieCountry>();
            MovieDirectors = new HashSet<MovieDirector>();
            MovieGenres = new HashSet<MovieGenre>();
            MovieLanguages = new HashSet<MovieLanguage>();
            MoviePromotions = new HashSet<MoviePromotion>();
            MovieSessions = new HashSet<MovieSession>();
            MovieWriters = new HashSet<MovieWriter>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string OriginalName { get; set; }
        public string Trailer { get; set; }
        public int Duration { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public int AgeLimit { get; set; }
        public string ImdbRaiting { get; set; }
        public string Description { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }

        public Entity Entity { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }
        public ICollection<MovieCountry> MovieCountries { get; set; }
        public ICollection<MovieDirector> MovieDirectors { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<MovieLanguage> MovieLanguages { get; set; }
        public ICollection<MoviePromotion> MoviePromotions { get; set; }
        public ICollection<MovieSession> MovieSessions { get; set; }
        public ICollection<MovieWriter> MovieWriters { get; set; }
    }
}
