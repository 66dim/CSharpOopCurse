namespace RangeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число - начало первого диапазона:");
            double from1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число - конец первого диапазона:");
            double to1 = Convert.ToDouble(Console.ReadLine());

            Range range1 = new Range(from1, to1);

            Console.WriteLine("Длина диапазона равна:{0}", range1.GetLength());

            Console.WriteLine("Введите число для проверки принадлежности диапазону:");
            double number = Convert.ToDouble(Console.ReadLine());

            if (range1.IsInside(number))
            {
                Console.WriteLine("Число {0} принадлежит диапазону:{1} ", number, range1.ToString());
            }
            else
            {
                Console.WriteLine("Число {0} не принадлежит диапазону:{1} ", number, range1.ToString());
            }

            Console.WriteLine("Введите число - начало второго диапазона:");
            double from2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число - конец второго диапазона:");
            double to2 = Convert.ToDouble(Console.ReadLine());

            Range range2 = new Range(from2, to2);

            Range? intersection = range1.GetIntersection(range2);

            if (intersection == null)
            {
                Console.WriteLine("Пересечения нет");
            }
            else
            {
                Console.WriteLine("Пересечение диапазонов:");
                Console.WriteLine(intersection.ToString());
            }

            Console.WriteLine("Объединение диапазонов:");
            range1.PrintArray(range1.GetUnion(range2));

            Console.WriteLine("Разность диапазонов:");
            range1.PrintArray(range1.GetDifference(range2));
        }
    }
}