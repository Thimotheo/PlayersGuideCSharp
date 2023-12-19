namespace Level30Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColoredItem<Sword> sword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
            ColoredItem<Bow> bow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Red);
            ColoredItem<Axe> axe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Green);

            sword.Display();
            bow.Display();
            axe.Display();
        }
    }
}