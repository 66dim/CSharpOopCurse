namespace RangeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число - начало диапазона: ");
            double from = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число - конец диапазона: ");
            double to = Convert.ToDouble(Console.ReadLine());

            Range range = new Range(from, to);

            Console.WriteLine("Длина диапазона равна: {0}", range.GetLength());

            Console.WriteLine("Введите число для проверки принадлежности диапазону:");
            double number = Convert.ToDouble(Console.ReadLine());

            if (range.IsInside(number))
            {
                Console.Write("Число {0} принадлежит диапазону: ", number);
            }
            else
            {
                Console.Write("Число {0} не принадлежит диапазону: ", number);
            }

            range.Print();

            Console.WriteLine("Введите число - начало второго диапазона: ");
            double interval2From = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число - конец второго диапазона: ");
            double Interval2To = Convert.ToDouble(Console.ReadLine());

            Range interval2 = new Range(interval2From, Interval2To);

            Range Intersection = range.GetIntersection(interval2);

            if (Intersection == null)
            {
                Console.WriteLine("Пересечения нет");
            }
            else
            {
                Console.WriteLine("Пересечение диапазонов:");
                Intersection.Print();
            }

            Range[] Union = range.GetUnion(interval2);

            Console.WriteLine("Объединение диапазонов:");

            for (int i = 0; i < Union.Length; i++)
            {
                Range temp = Union[i];
                temp.Print();
            }

            Range[] Difference = range.GetDifference(interval2);

            if (Difference == null)
            {
                Console.WriteLine("Разность равна 0");
            }
            else
            {
                Console.WriteLine("Разность диапазонов:");

                for (int i = 0; i < Difference.Length; i++)
                {
                    Range temp = Difference[i];
                    temp.Print();
                }
            }
        }
    }
}