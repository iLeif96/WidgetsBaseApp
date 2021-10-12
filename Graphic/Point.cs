namespace iLeif.Graphic
{
    public struct Point
    {
        public Unit XUnit { get; set; }
        public Unit YUnit { get; set; }
        public Unit ZUnit { get; set; }

        public Point(Unit x, Unit y)
        {
            XUnit = x;
            YUnit = y;
            ZUnit = new Unit(0);
        }

        public double X => XUnit.Value;
        public double Y => YUnit.Value;
        public double Z => YUnit.Value;
    }
}
