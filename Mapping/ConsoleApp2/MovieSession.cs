namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MovieSession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MovieSession()
        {
            Orders = new HashSet<Order>();
            SessionPrices = new HashSet<SessionPrice>();
        }

        public long Id { get; set; }

        public DateTimeOffset Time { get; set; }

        public long HallId { get; set; }

        public long MovieId { get; set; }

        public virtual Hall Hall { get; set; }

        public virtual Movy Movy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionPrice> SessionPrices { get; set; }
    }
}