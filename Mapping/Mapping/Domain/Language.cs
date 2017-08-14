using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class Language : BaseEntity
    {
        public virtual string Name { get; set; }
        
        public virtual IList<Movie> Movies { get; set; }
    }
}
