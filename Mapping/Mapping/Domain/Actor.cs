using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class Actor : BaseEntity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual IList<Movie> Movies { get; set; }
    }
}
