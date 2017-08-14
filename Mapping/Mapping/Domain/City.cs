using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class City : BaseEntity
    {
        public virtual string Name { get; set; }
        
        public virtual IList<Cinema> Cinemas { get; set; }
    }
}
