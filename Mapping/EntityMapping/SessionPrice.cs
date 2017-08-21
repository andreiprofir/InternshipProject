namespace EntityMapping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SessionPrice
    {
        public long Id { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public long MovieSessionId { get; set; }

        public long SeatTypeId { get; set; }

        public virtual MovieSession MovieSession { get; set; }

        public virtual SeatType SeatType { get; set; }
    }
}
