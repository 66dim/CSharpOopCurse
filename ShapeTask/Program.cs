namespace ShapeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapesArray = new IShape[]
            {
                 new Square(6),
                 new Rectangle(4, 2),
                 new Triangle(7, 7, 11, 11, 4, 8),
                 new Circle(2),
                 new Square(9),
                 new Circle(5),
                 new Triangle(4, 4, 8, 8, 10, 4),
                 new Rectangle(1, 2),
            };

            Console.WriteLine("Фигура с максимальной площадью:");
            Console.WriteLine(GetMaxAreaShape(shapesArray));

            Console.WriteLine();

            Console.WriteLine("Фигура со вторым по величине периметром:");
            Console.WriteLine(GetSecondPerimeterShape(shapesArray));

            Console.WriteLine();

            Console.WriteLine("Сравним две фигуры:");
            Console.WriteLine(shapesArray[0]);
            Console.WriteLine($"{"Хэш код:"}{shapesArray[0].GetHashCode()}");

            Console.WriteLine();

            Console.WriteLine(shapesArray[7]);
            Console.WriteLine($"{"Хэш код:"}{shapesArray[7].GetHashCode()}");

            if (shapesArray[0].Equals(shapesArray[7]))
            {
                Console.WriteLine("Фигуры равны.");
            }
            else
            {
                Console.WriteLine("Фигуры не равны");
            }
        }

        static IShape GetMaxAreaShape(IShape[] shapesArray)
        {
            Array.Sort(shapesArray, new ShapesByAreaComparer());

            return shapesArray[shapesArray.Length - 1];
        }

        static IShape GetSecondPerimeterShape(IShape[] shapesArray)
        {
            Array.Sort(shapesArray, new ShapesByPerimeterComparer());

            return shapesArray[1];
        }
    }
}