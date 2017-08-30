using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Cinema
    {
        public Cinema()
        {
            CinemaPromotions = new HashSet<CinemaPromotion>();
            Halls = new HashSet<Hall>();
        }

        public long Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Street { get; set; }
        public string ContactPhone { get; set; }
        public string Info { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public long CityId { get; set; }

        public City City { get; set; }
        public Entity Entity { get; set; }
        public ICollection<CinemaPromotion> CinemaPromotions { get; set; }
        public ICollection<Hall> Halls { get; set; }
    }
}
