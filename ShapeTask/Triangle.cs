namespace ShapeTask
{
    public class Triangle : IShape
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }

        private double side1;
        private double side2;
        private double side3;

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3) : base()
        {
            X1 = x1;
            Y1 = y1;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;

            side1 = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - y1));
            side2 = Math.Sqrt((X3 - X2) * (X3 - X2) + (Y3 - Y2) * (Y3 - y2));
            side3 = Math.Sqrt((X1 - X3) * (X1 - X3) + (Y1 - Y3) * (Y1 - y3));
        }

        public override string ToString()
        {
            return $"{"Треугольник:"} {"сторона 1:"}{side1:#.##} {"сторона 2:"}{side2:#.##} {"сторона 3:"}{side3:#.##} {"ширина:"}{GetWidth():#.##} {"высота:"}{GetHeight():#.##} {"площадь:"}{GetArea():#.##} {"периметр:"}{GetPerimeter():#.##}";
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

            Triangle newTriangle = (Triangle)o;

            return X1 == newTriangle.X1 && Y1 == newTriangle.Y1 && X2 == newTriangle.X2 && Y2 == newTriangle.Y2 && X3 == newTriangle.X3 && Y3 == newTriangle.Y3;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = (int)(prime * hash + X1);
            hash = (int)(prime * hash + Y1.GetHashCode());
            hash = (int)(prime * hash + X2.GetHashCode());
            hash = (int)(prime * hash + Y2.GetHashCode());
            hash = (int)(prime * hash + X3.GetHashCode());
            hash = (int)(prime * hash + Y3.GetHashCode());

            return hash;
        }

        public override double GetHeight()
        {
            return Math.Max(Y3, Math.Max(Y1, Y2)) - Math.Min(Y3, Math.Min(Y1, Y2));
        }

        public override double GetWidth()
        {
            return Math.Max(X3, Math.Max(X1, X2)) - Math.Min(X3, Math.Min(X1, X2));
        }

        public override double GetArea()
        {
            double perimeterHalf = GetPerimeter() / 2;
            return Math.Sqrt(perimeterHalf * (perimeterHalf - side1) * (perimeterHalf - side2) * (perimeterHalf - side3));
        }

        public override double GetPerimeter()
        {
            return side1 + side2 + side3;
        }
    }
}