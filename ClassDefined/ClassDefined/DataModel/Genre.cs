using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDefined.DataModel
{
    public class Genre
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Poster { get; set; }

        public List<Movie> Movies { get; set; }
    }
}