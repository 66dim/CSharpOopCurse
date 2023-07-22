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

        public void Print()
        {
            Console.WriteLine("({0};{1})", From, To);
        }

        public Range GetIntersection(Range interval2)
        {
            double interval2From = interval2.From;
            double interval2To = interval2.To;

            if (From <= interval2From && To >= interval2To)
            {
                return new Range(interval2From, interval2To);
            }

            if (From > interval2From && To < interval2To)
            {
                return new Range(From, To);
            }

            if (From < interval2From && To < interval2To && To > interval2From)
            {
                return new Range(interval2From, To);
            }

            if (interval2From < From && interval2To < To && interval2To > From)
            {
                return new Range(From, interval2To);
            }

            return null;
        }

        public Range[] GetUnion(Range interval2)
        {
            double interval2From = interval2.From;
            double interval2To = interval2.To;

            if (From <= interval2From && To >= interval2To)
            {
                Range[] rangesArray = new Range[1];
                rangesArray[0] = new Range(From, To);
                return rangesArray;
            }

            if (From > interval2From && To < interval2To)
            {
                Range[] rangesArray = new Range[1];
                rangesArray[0] = new Range(interval2From, interval2To);
                return rangesArray;
            }

            if (From < interval2From && To < interval2To && To >= interval2From)
            {
                Range[] rangesArray = new Range[1];
                rangesArray[0] = new Range(From, interval2To);
                return rangesArray;
            }

            if (interval2From < From && interval2To < To && interval2To >= From)
            {
                Range[] rangesArray = new Range[1];
                rangesArray[0] = new Range(interval2From, To);
                return rangesArray;
            }

            Range[] rangesArray2 = new Range[2];
            rangesArray2[0] = new Range(From, To);
            rangesArray2[1] = new Range(interval2From, interval2To);
            return rangesArray2;
        }

        public Range[] GetDifference(Range interval2)
        {
            double interval2From = interval2.From;
            double interval2To = interval2.To;

            if (From < interval2From && To < interval2To && To > interval2From)
            {
                Range[] rangesArray = new Range[1];
                rangesArray[0] = new Range(From, interval2From);
                return rangesArray;
            }

            if (From < interval2From && To > interval2To)
            {
                Range[] rangesArray = new Range[2];
                rangesArray[0] = new Range(From, interval2From);
                rangesArray[1] = new Range(interval2To, To);
                return rangesArray;
            }

            return null;
        }
    }
}
