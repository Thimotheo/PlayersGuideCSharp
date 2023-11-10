namespace Level25Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new(15, 20, 30);
            while (pack.CurrentItemCount < pack.MaxItemCount || pack.CurrentWeight < pack.MaxWeight || pack.CurrentVolume < pack.CurrentVolume)
            {
                Console.WriteLine($"The pack currently contains {pack.CurrentItemCount} items." +
                              $" They weigh {pack.CurrentWeight} and their volume is " +
                              $"{pack.CurrentVolume}.");
                string[] items = { "Arrow", "Bow", "Rope", "Water", "Food", "Sword" };
                Console.WriteLine("Enter the number of the item you would like to add:");
                foreach (var item in items.Select((name, index) => (name, index)))
                {
                    Console.WriteLine($"{item.index + 1}. {item.name}");
                }

                int choice = Convert.ToInt32(Console.ReadLine());

                InventoryItem newItem = choice switch
                {
                    1 => new Arrow(),
                    2 => new Bow(),
                    3 => new Rope(),
                    4 => new Water(),
                    5 => new Food(),
                    6 => new Sword(),

                };
                if (!pack.Add(newItem))
                    Console.WriteLine("That item could not be added to the pack.");
                else
                    Console.WriteLine("Item was added successfully!"); ;
            }

        }
    }
}