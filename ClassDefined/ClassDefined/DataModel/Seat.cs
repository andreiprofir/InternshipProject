using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassDefined.DataModel;

namespace ClassDefined.DataModel
{
    public class Seat
    {
        public long Id { get; set; }

        public int Number { get; set; }

        public int RowNumber { get; set; }

        public SeatType Type { get; set; }
    }
}