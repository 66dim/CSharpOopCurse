namespace ShapeTask
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base()
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return $"{"Круг:"} {"радиус:"}{Radius:#.##} {"ширина:"}{GetWidth():#.##} {"высота:"}{GetHeight():#.##} {"площадь:"}{GetArea():#.##} {"периметр:"}{GetPerimeter():#.##}";
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

            Circle newCircle = (Circle)o;

            return Radius == newCircle.Radius;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            return hash = (int)(prime * hash + Radius);
        }

        public override double GetHeight()
        {
            return Radius * 2;
        }

        public override double GetWidth()
        {
            return Radius * 2;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return Math.PI * Radius * 2;
        }
    }
}