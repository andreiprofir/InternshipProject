namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comment()
        {
            Comments1 = new HashSet<Comment>();
        }

        public long Id { get; set; }

        public DateTimeOffset Date { get; set; }

        public int Likes { get; set; }

        [Required]
        [StringLength(1024)]
        public string Text { get; set; }

        public long UserId { get; set; }

        public long EntityId { get; set; }

        public long? AnswerToId { get; set; }

        public long? CommentTypeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments1 { get; set; }

        public virtual Comment Comment1 { get; set; }

        public virtual CommentType CommentType { get; set; }

        public virtual Entity Entity { get; set; }

        public virtual User User { get; set; }
    }
}
