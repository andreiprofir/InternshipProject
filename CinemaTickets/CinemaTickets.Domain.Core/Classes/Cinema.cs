using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Classes
{
    public partial class Cinema : BaseEntity
    {
        public Cinema()
        {
            Halls = new HashSet<Hall>();
            Promotions = new HashSet<Promotion>();
        }
        
        public string ShortName { get; set; }
        
        public string FullName { get; set; }
        
        public string Street { get; set; }
        
        public string ContactPhone { get; set; }

        public string Info { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public long CityId { get; set; }

        public virtual City City { get; set; }

        public virtual Entity Entity { get; set; }

        public virtual ICollection<Hall> Halls { get; set; }

        public virtual ICollection<Promotion> Promotions { get; set; }
    }
}
