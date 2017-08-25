using System;
using System.Collections.Generic;

namespace CinemaTickets.Domain.Core.Models
{
    public partial class Promotion
    {
        public Promotion()
        {
            CinemaPromotions = new HashSet<CinemaPromotion>();
            MoviePromotions = new HashSet<MoviePromotion>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string DescriptionOfRules { get; set; }
        public DateTimeOffset? ValidFrom { get; set; }
        public DateTimeOffset? ValidTo { get; set; }

        public Entity IdNavigation { get; set; }
        public ICollection<CinemaPromotion> CinemaPromotions { get; set; }
        public ICollection<MoviePromotion> MoviePromotions { get; set; }
    }
}
