namespace Level8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";

            Console.WriteLine("Target row?");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Target column?");
            int column = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"({column}, {row - 1})");
            Console.WriteLine($"({column - 1}, {row})");
            Console.WriteLine($"({column}, {row + 1})");
            Console.WriteLine($"({column + 1}, {row})");

            Console.Beep();
        }
    }
}