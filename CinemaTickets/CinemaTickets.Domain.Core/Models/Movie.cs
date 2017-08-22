using System;
using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Movie : BaseEntity
    {
        public Movie()
        {
            MovieSessions = new HashSet<MovieSession>();
            Actors = new HashSet<Actor>();
            Countries = new HashSet<Country>();
            Directors = new HashSet<Director>();
            Genres = new HashSet<Genre>();
            Languages = new HashSet<Language>();
            Promotions = new HashSet<Promotion>();
            Writers = new HashSet<Writer>();
        }
        
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

        public virtual Entity Entity { get; set; }

        public virtual ICollection<MovieSession> MovieSessions { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }

        public virtual ICollection<Country> Countries { get; set; }

        public virtual ICollection<Director> Directors { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }

        public virtual ICollection<Language> Languages { get; set; }

        public virtual ICollection<Promotion> Promotions { get; set; }

        public virtual ICollection<Writer> Writers { get; set; }
    }
}
