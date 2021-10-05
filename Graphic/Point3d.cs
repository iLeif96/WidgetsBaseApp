using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Graphic
{
    public class Point3d : Point
    {
        public Unit ZUnit { get; set; }
        public double Z => ZUnit.Value;
    }
}
