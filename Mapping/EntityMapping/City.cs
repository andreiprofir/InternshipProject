namespace EntityMapping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class City
    {
        public City()
        {
            Cinemas = new HashSet<Cinema>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cinema> Cinemas { get; set; }
    }
}
