using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Level14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game();
        }

        static void Game()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Player 1, you have control of the Manticore. ");
            int placement = CheckForNumber("How far away from the city do you want to station the Manticore?");
            int cityHP = 15;
            int manticoreHP = 10;
            int roundNumber = 1;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Player 2, it is your turn. You control the city's cannon.");
            while (cityHP > 0 && manticoreHP > 0)
            {
                int damage = CannonDamageCalc(roundNumber);

                Console.WriteLine("-----------------------------------------------------------" +
                $"\r\nSTATUS: Round: {roundNumber} City: {cityHP}/15 Manticore: {manticoreHP}/10" +
                $"\r\nThe cannon is expected to deal {damage} damage this round.");

                int input = CheckForNumber("Enter desired cannon range: ");
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\r\nThat round {ShotPlacement()} the target.");

                    if (manticoreHP > 0)
                        cityHP--;

                    if (placement == input)
                        manticoreHP -= damage;

                    roundNumber++;

                    string ShotPlacement()
                    {
                        if (placement < input) { return "OVERSHOT"; }
                        else if (placement > input) { return "FELL SHORT OF"; }
                        else { return "HIT"; }
                    }
                }

                int CannonDamageCalc(int roundNumber)
                {
                    if (roundNumber % 5 == 0 && roundNumber % 3 == 0)
                        return 10;
                    else if (roundNumber % 5 == 0)
                        return 3;
                    else if (roundNumber % 3 == 0)
                        return 3;
                    return 1;
                }

                if (cityHP == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The city is destroyed. The Uncoded One has won.");
                }

                if (manticoreHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The Manticore is destroyed. The city of Consolas has been saved!");
                }

            }

            int CheckForNumber(string text)
            {
                int input = 0;
                while (true)
                {
                    Console.WriteLine(text);
                    if (int.TryParse(Console.ReadLine(), out input))
                    {
                        break;
                    }
                    Console.WriteLine("This is not a correct input. Please try again. ");
                }
                return input;
            }
        }
    }
}