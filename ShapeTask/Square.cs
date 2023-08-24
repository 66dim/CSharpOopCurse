namespace ShapeTask
{
    public class Square : IShape
    {
        public double Side { get; set; }

        private const int sidesNumber = 4;

        public Square(double side)
        {
            Side = side;
        }

        public override string ToString()
        {
            return $"{"Квадрат:"} {"сторона:"}{Side:#.##} {"ширина:"}{GetWidth():#.##} {"высота:"}{GetHeight():#.##} {"площадь:":#.##}{GetArea()} {"периметр:"}{GetPerimeter():#.##}";
        }

        public override bool Equals(object? o)
        {
            if (ReferenceEquals(o, this))
            {
                return true;
            }

            if (ReferenceEquals(o, null) || o.GetType() != GetType())
            {
                return false;
            }

            Square newSquare = (Square)o;

            return Side == newSquare.Side;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            return (int)(prime * hash + Side);
        }

        public double GetHeight()
        {
            return Side;
        }

        public double GetWidth()
        {
            return Side;
        }

        public double GetArea()
        {
            return Side * Side;
        }

        public double GetPerimeter()
        {
            return Side * sidesNumber;
        }
    }
}