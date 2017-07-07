using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDefined.DataModel
{
    public class Hall
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public Seat[][] Seats { get; set; }

        public HallType Type { get; set; }
    }
}
