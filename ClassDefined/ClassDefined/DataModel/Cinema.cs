using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDefined.DataModel
{
    public class Cinema
    {
        public long Id
        {
            get => default(int);
            set
            {
            }
        }

        public string ShortName
        {
            get => default(string);
            set
            {
            }
        }

        public string LongName
        {
            get => default(string);
            set
            {
            }
        }

        public string Address
        {
            get => default(string);
            set
            {
            }
        }

        public List<string> ContactPhones
        {
            get => new List<string>();
            set
            {
            }
        }

        public string City
        {
            get => default(string);
            set
            {
            }
        }

        public string Info
        {
            get => default(string);
            set
            {
            }
        }

        public int? Likes
        {
            get => default(int);
            set
            {
            }
        }

        public int? Dislikes
        {
            get => default(int);
            set
            {
            }
        }

        public List<string> Photos
        {
            get => new List<string>();
            set
            {
            }
        }

        public List<Hall> Halls
        {
            get; set;
        }

        public List<Comment> Reviews
        {
            get => default(int);
            set
            {
            }
        }
    }
}