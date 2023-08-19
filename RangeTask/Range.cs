namespace RangeTask
{
    public class Range
    {
        public double From { get; set; }

        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            return number >= From && number <= To;
        }

        public override string ToString()
        {
            return $"({From}; {To})";
        }

        public void PrintArray(Range[] array)
        {
            Console.Write("[");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString());

                if (i != array.Length - 1)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine("]");
        }

        public Range? GetIntersection(Range range)
        {
            if (From == range.From && To == range.To)
            {
                return range;
            }

            if (To <= range.From || From >= range.To)
            {
                return null;
            }

            return new Range(Math.Max(From, range.From), Math.Min(To, range.To));
        }

        public Range[] GetUnion(Range range)
        {
            if (From == range.From && To == range.To)
            {
                return new Range[] { range };
            }

            if (To < range.From || From > range.To)
            {
                return new Range[] { new Range(From, To), range };
            }

            return new Range[] { new Range(Math.Min(From, range.From), Math.Max(To, range.To)) };
        }

        public Range[] GetDifference(Range range)
        {
            if ((From == range.From && To == range.To) || (To <= range.From || From >= range.To) || (From > range.From && To < range.To))
            {
                return new Range[] { };
            }

            if (From < range.From && To > range.To)
            {
                return new Range[] { new Range(From, range.From), new Range(range.To, To) };
            }

            if (From < range.From)
            {
                return new Range[] { new Range(From, range.From) };
            }
            else
            {
                return new Range[] { new Range(range.To, To) };
            }
        }
    }
}