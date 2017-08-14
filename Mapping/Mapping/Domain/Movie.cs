using System;
using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class Movie : BaseEntity
    {
        public virtual string Name { get; set; }

        public virtual string OriginalName { get; set; }
        
        public virtual string Trailer { get; set; }

        public virtual int Duration { get; set; }
        
        public virtual DateTimeOffset? ReleaseDate { get; set; }

        public int? AgeLimit { get; set; }
        
        public virtual string ImdbRaiting { get; set; }
        
        public virtual string Description { get; set; }

        public virtual int Likes { get; set; }

        public virtual int Dislikes { get; set; }

        public virtual Entity Entity { get; set; }
        
        public virtual IList<MovieSession> MovieSessions { get; set; }
        
        public virtual IList<Director> Directors { get; set; }
        
        public virtual IList<Genre> Genres { get; set; }
        
        public virtual IList<Promotion> Promotions { get; set; }
        
        public virtual IList<Actor> Actors { get; set; }
        
        public virtual IList<Country> Countries { get; set; }
        
        public virtual IList<Language> Languages { get; set; }
        
        public virtual IList<Writer> Writers { get; set; }
    }
}
