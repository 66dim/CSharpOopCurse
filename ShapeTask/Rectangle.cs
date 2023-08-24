namespace ShapeTask
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
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

        public double GetHeight()
        {
            return Height;
        }

        public double GetWidth()
        {
            return Width;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public double GetPerimeter()
        {
            return (Width + Height) * 2;
        }
    }
}