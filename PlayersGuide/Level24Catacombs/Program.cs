namespace Level24Catacombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point();
        }

        static void Point()
        {
            Point One = new Point(2, 3);
            Point Two = new Point(-4, 0);

            Console.WriteLine($"({One.XCoordinate}, {One.YCoordinate})");
            Console.WriteLine($"({Two.XCoordinate}, {Two.YCoordinate})");
        }
    }
}