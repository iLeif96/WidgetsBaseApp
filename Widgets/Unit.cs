namespace iLeif.Widgets
{
    public enum UnitType { Mm, Inch, Pixel, Percent }
    public struct Unit
    {
        double Value { get; set; }

        UnitType UType { get; set; }

        public Unit(double value, UnitType unitType = UnitType.Pixel)
        {
            Value = value;
            UType = unitType;
        }

        Unit ConvertTo(UnitType uT)
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
    }
}
