using static Level16.States;

namespace Level16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChestState currentState = ChestState.Locked;
            while (true)
            {
                Console.WriteLine($"The chest is {LowerCase(currentState)}. What do you want to do?");

                string input = Console.ReadLine();
                if (currentState == ChestState.Locked && input == "unlock") { currentState = ChestState.Closed; }
                if (currentState == ChestState.Closed && input == "open") { currentState = ChestState.Open; }
                if (currentState == ChestState.Open && input == "close") { currentState = ChestState.Closed; }
                if (currentState == ChestState.Closed && input == "lock") { currentState = ChestState.Locked; }
            }

            string LowerCase(ChestState chestState)
            {
                return chestState.ToString().ToLower();
            }

        }
    }
}