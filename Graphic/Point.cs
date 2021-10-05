using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Graphic
{
    public class Point
    {
        public Unit XUnit { get; set; }
        public Unit YUnit { get; set; }

        public double X => XUnit.Value;
        public double Y => YUnit.Value;
    }
}
