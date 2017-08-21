using System.Collections.Generic;

namespace EntityMapping
{
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
