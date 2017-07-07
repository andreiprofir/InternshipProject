using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDefined.DataModel
{
    public class Promotion
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string DescriptionOfRules { get; set; }

        public string Poster { get; set; }

        public System.DateTimeOffset ValidFrom { get; set; }

        public System.DateTimeOffset ValidTo { get; set; }

        public List<Movie> Movies { get; set; }

        public List<Cinema> Cinemas { get; set; }
    }
}