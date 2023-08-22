namespace ShapeTask
{
    public class ShapesByAreaComparer : IComparer<IShape>
    {
        public int Compare(IShape? shape1, IShape? shape2)
        {
            if (shape1 is null || shape2 is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }

            if ((shape1.GetArea() - shape2.GetArea()) > 0)
            {
                return 1;
            }

            if ((shape1.GetArea() - shape2.GetArea()) < 0)
            {
                return -1;
            }

            return 0;
        }
    }

    public class ShapesByPerimeterComparer : IComparer<IShape>
    {
        public int Compare(IShape? shape1, IShape? shape2)
        {
            if (shape1 is null || shape2 is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }

            if ((shape1.GetPerimeter() - shape2.GetPerimeter()) > 0)
            {
                return 1;
            }

            if ((shape1.GetPerimeter() - shape2.GetPerimeter()) < 0)
            {
                return -1;
            }

            return 0;
        }
    }
}