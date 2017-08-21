namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cinema
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cinema()
        {
            Halls = new HashSet<Hall>();
            Promotions = new HashSet<Promotion>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(128)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(255)]
        public string Street { get; set; }

        [Required]
        [StringLength(128)]
        public string ContactPhone { get; set; }

        public string Info { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public long CityId { get; set; }

        public virtual City City { get; set; }

        public virtual Entity Entity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hall> Halls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promotion> Promotions { get; set; }
    }
}
