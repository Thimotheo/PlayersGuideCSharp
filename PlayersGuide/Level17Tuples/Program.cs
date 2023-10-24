using static Level17Tuples.MainIngredient;
using static Level17Tuples.Seasoning;
using static Level17Tuples.SoupType;

namespace Level17Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (SeasoningStyle seasoning, Ingredient ingredient, StyleSoup styleSoup) soup = (0, 0, 0);

            Console.WriteLine("Let's make a soup!");
            Console.WriteLine("What seasoning do you want? Choose a number: ");
            Console.WriteLine("1. Spicy");
            Console.WriteLine("2. Salty");
            Console.WriteLine("3. Sweet");
            int seasoningChoice = Convert.ToInt32(Console.ReadLine());
            if (seasoningChoice == 1)
                soup.seasoning = SeasoningStyle.Spicy;
            else if (seasoningChoice == 2)
                soup.seasoning = SeasoningStyle.Sweet;
            else if (seasoningChoice == 3)
                soup.seasoning = SeasoningStyle.Salty;

            Console.WriteLine("What is the main ingredient? Choose a number: ");
            Console.WriteLine("1. Mushrooms");
            Console.WriteLine("2. Chicken");
            Console.WriteLine("3. Carrots");
            Console.WriteLine("4. Potatoes");
            int ingredientChoice = Convert.ToInt32(Console.ReadLine());
            if (ingredientChoice == 1)
                soup.ingredient = Ingredient.Mushrooms;
            else if (ingredientChoice == 2)
                soup.ingredient = Ingredient.Chicken;
            else if (ingredientChoice == 3)
                soup.ingredient = Ingredient.Carrots;
            else if (ingredientChoice == 4)
                soup.ingredient = Ingredient.Potatoes;

            Console.WriteLine("What type of soup do you want to make? Choose a number.");
            Console.WriteLine("1. Soup");
            Console.WriteLine("2. Stew");
            Console.WriteLine("3. Gumbo");
            int soupChoice = Convert.ToInt32(Console.ReadLine());
            if (soupChoice == 1)
                soup.styleSoup = StyleSoup.Soup;
            else if (soupChoice == 2)
                soup.styleSoup = StyleSoup.Stew;
            else if (soupChoice == 3)
                soup.styleSoup = StyleSoup.Gumbo;

            var soupSelection = CreateSoup(soup);
            DisplaySoup(soupSelection);
        }

        static void DisplaySoup((SeasoningStyle seasoning, Ingredient ingredient, StyleSoup styleSoup) soup)
        {
            Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.styleSoup}");
        }

        static (SeasoningStyle seasoning, Ingredient ingredient, StyleSoup styleSoup) CreateSoup((SeasoningStyle seasoning, Ingredient ingredient, StyleSoup styleSoup) soup)
            => (soup.seasoning, soup.ingredient, soup.styleSoup);

    }
}