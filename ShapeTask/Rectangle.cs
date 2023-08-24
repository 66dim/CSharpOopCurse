namespace ShapeTask
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) : base()
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{"Прямоугольник:"} {"ширина:"}{GetWidth():#.##} {"высота:"}{GetHeight():#.##} {"площадь:"}{GetArea():#.##} {"периметр:"}{GetPerimeter():#.##}";
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

            Rectangle newRectangle = (Rectangle)o;

            return Width == newRectangle.Width && Height == newRectangle.Height;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = (int)(prime * hash + Width);
            hash = (int)(prime * hash + Height.GetHashCode());

            return hash;
        }

        public override double GetHeight()
        {
            return Height;
        }

        public override double GetWidth()
        {
            return Width;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return (Width + Height) * 2;
        }
    }
}