namespace LevelFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of thing are we talking about?");
            //This is an object
            string a = Console.ReadLine();
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            //This describes the object
            string b = Console.ReadLine();
            /* This classifies it as a Doom object*/
            string c = "of Doom";
            //This defines the version of the object
            string d = "3000";
            Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
        }
    }
}