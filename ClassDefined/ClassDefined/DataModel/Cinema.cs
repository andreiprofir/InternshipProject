using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDefined.DataModel
{
    public class Cinema
    {
        public long Id { get; set; }

        public string ShortName { get; set; }

        public string LongName { get; set; }

        public string Address { get; set; }

        public List<string> ContactPhones { get; set; }

        public string City { get; set; }

        public string Info { get; set; }

        public int? Likes { get; set; }

        public int? Dislikes { get; set; }

        public List<string> Photos { get; set; }

        public List<Hall> Halls
        {
            get; set;
        }

        public List<Comment> Reviews { get; set; }
    }
}