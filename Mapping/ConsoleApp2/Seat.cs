namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Seat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seat()
        {
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Identifier { get; set; }

        public int RowNumber { get; set; }

        public int ColumnNumber { get; set; }

        public bool IsBusy { get; set; }

        public long HallId { get; set; }

        public long SeatTypeId { get; set; }

        public virtual Hall Hall { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        public virtual SeatType SeatType { get; set; }
    }
}
