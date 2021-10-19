namespace iLeif.Graphic
{
    public enum UnitType { Mm, Inch, Pixel, Percent }
    public struct Unit
    {
        public double Value { get; set; }
        public UnitType UType { get; set; }

        public Unit(double value, UnitType unitType = UnitType.Pixel)
        {
            Value = value;
            UType = unitType;
        }

        private Unit ConvertTo(UnitType uT)
        {
            if (UType == uT)
            {
                return this;
            }

            if (UType == UnitType.Mm && uT == UnitType.Inch)
            {
                return new Unit(Value * 0.039, uT);
            }

            if (UType == UnitType.Inch && uT == UnitType.Mm)
            {
                return new Unit(Value * 25.4, uT);
            }

            return this;
        }

        public override bool Equals(object obj) => (obj is Unit unit) && unit.Value == Value && unit.UType == UType;

        public static implicit operator Unit(int pixel) => new Unit(pixel, UnitType.Pixel);
        public static implicit operator Unit(double mm) => new Unit(mm, UnitType.Mm);
    }
}
