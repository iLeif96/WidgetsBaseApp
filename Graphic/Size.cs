using System;

namespace iLeif.Graphic
{
    public class Size : ICloneable
    {
        public Unit Width { get; set; }
        public Unit Height { get; set; }

        public object Clone() => MemberwiseClone();

        public override bool Equals(object obj) => ((obj is Size second) && second.Width.Equals(Width) && second.Height.Equals(Height));
    }
}
