namespace Level28Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coordinate a = new Coordinate(1, 1);
            Coordinate b = new Coordinate(1, 2);
            Coordinate c = new Coordinate(2, 2);

            Console.WriteLine(Coordinate.CheckIfAdjacent(a, b));
            Console.WriteLine(Coordinate.CheckIfAdjacent(b, c));
            Console.WriteLine(Coordinate.CheckIfAdjacent(a, c));

        }
    }
}