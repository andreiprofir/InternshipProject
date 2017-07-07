using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDefined.DataModel
{
    public class Movie
    {
        public long Id
        {
            get => default(int);
            set
            {
            }
        }

        public string Name
        {
            get => default(string);
            set
            {
            }
        }

        public string OriginalName
        {
            get => default(string);
            set
            {
            }
        }

        public string MainPoster
        {
            get => default(string);
            set
            {
            }
        }

        public string Poster
        {
            get => default(string);
            set
            {
            }
        }

        public string Trailer
        {
            get => default(string);
            set
            {
            }
        }

        public TimeSpan Duration
        {
            get => TimeSpan.MaxValue;
            set
            {
            }
        }

        public DateTimeOffset ReleaseDate
        {
            get => DateTimeOffset.Now;
            set
            {
            }
        }

        public string Language
        {
            get => default(string);
            set
            {
            }
        }

        public int AgeLimit
        {
            get => default(int);
            set
            {
            }
        }

        public string ImdbRaiting
        {
            get => default(string);
            set
            {
            }
        }

        public string Director
        {
            get => default(string);
            set
            {
            }
        }

        public List<string> LeadRoles
        {
            get => null;
            set
            {
            }
        }

        public string Description
        {
            get => default(string);
            set
            {
            }
        }

        public int Likes
        {
            get => default(int);
            set
            {
            }
        }

        public int Dislikes
        {
            get => default(int);
            set
            {
            }
        }

        public List<Genre> Genres
        {
            get => null;
            set
            {
            }
        }

        public List<Comment> Comments
        {
            get => null;
            set { }
        }
    }
}