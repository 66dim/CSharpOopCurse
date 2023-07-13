namespace RangeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число - начало диапазона: ");
            double start = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число - конец диапазона: ");
            double end = Convert.ToDouble(Console.ReadLine());

            Range range = new Range(start, end);

            double length = range.GetLength();
            Console.WriteLine("Длина диапазона равна: " + length);

            Console.WriteLine("Введите число для проверки принадлежности диапазону:");
            double number = Convert.ToDouble(Console.ReadLine());

            if (range.IsInside(number))
            {
                Console.WriteLine("Число {0} принадлежит диапазону", number);
            }
            else
            {
                Console.WriteLine("Число {0} не принадлежит диапазону", number);
            }

            range.Print();
        }
    }
}