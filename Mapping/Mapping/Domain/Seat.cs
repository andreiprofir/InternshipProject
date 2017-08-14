using System.Collections.Generic;

namespace ConsoleApp1.Domain
{
    public class Seat : BaseEntity
    {
        public virtual string Identifier { get; set; }

        public virtual int RowNumber { get; set; }

        public virtual int ColumnNumber { get; set; }

        public virtual bool IsBusy { get; set; }

        public virtual Hall Hall { get; set; }
        
        public virtual IList<Order> Orders { get; set; }

        public virtual SeatType SeatType { get; set; }
    }
}
