using System;
using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class Promotion : BaseEntity
    {
        public virtual string Title { get; set; }
        
        public virtual string ShortDescription { get; set; }

        public virtual string DescriptionOfRules { get; set; }

        public virtual DateTimeOffset ValidFrom { get; set; }

        public virtual DateTimeOffset ValidTo { get; set; }

        public virtual Entity Entity { get; set; }
        
        public virtual IList<Cinema> Cinemas { get; set; }
        
        public virtual IList<Movie> Movies { get; set; }
    }
}
