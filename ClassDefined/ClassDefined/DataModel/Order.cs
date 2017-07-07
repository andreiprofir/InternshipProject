using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDefined.DataModel
{
    public class Order
    {
        public long Id { get; set; }

        public User User { get; set; }

        public Session Session { get; set; }

        public Seat Seat { get; set; }
    }
}