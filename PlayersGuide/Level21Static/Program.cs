using Extensions;
using static Level21Static.Arrowhead;
using static Level21Static.Fletching;

namespace Level21Static
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What type of arrow do you want?");
            Console.WriteLine("1. Elite arrow");
            Console.WriteLine("2. Beginner arrow");
            Console.WriteLine("3. Marksman arrow");
            Console.WriteLine("4. Custom arrow");
            string? choice = Console.ReadLine();
            Arrow arrow = choice switch
            {
                "1" => Arrow.CreateEliteArrow(),
                "2" => Arrow.CreateBeginnerArrow(),
                "3" => Arrow.CreateMarksmanArrow(),
                "4" => GetCustomArrow(),
                _ => throw new KeyNotFoundException()
            };
            Console.WriteLine($"This arrow costs {arrow.GetCost()} gold.");

            Arrow GetCustomArrow()
            {
                ArrowheadType arrowhead = GetArrowheadType();
                FletchingType fletching = GetFletchingType();
                float length = GetShaftLength();

                return new Arrow(arrowhead, fletching, length);
            }

            ArrowheadType GetArrowheadType()
            {
                Console.WriteLine("What type of arrowhead do you want? (steel, wood, obsidian) ");
                string? input = Console.ReadLine();
                return input switch
                {
                    "steel" => ArrowheadType.Steel,
                    "wood" => ArrowheadType.Wood,
                    "obsidian" => ArrowheadType.Obsidian,
                    _ => throw new KeyNotFoundException(),
                };
            }

            FletchingType GetFletchingType()
            {
                Console.WriteLine("What type of fletching do you want? (plastic, turkey feathers, goose feathers)");
                string? input = Console.ReadLine();
                return input switch
                {
                    "plastic" => FletchingType.Plastic,
                    "turkey feathers" => FletchingType.TurkeyFeathers,
                    "goose feathers" => FletchingType.GooseFeathers,
                    _ => throw new KeyNotFoundException()
                }; ;
            }

            float GetShaftLength()
            {
                float length = TakingANumber.AskForNumberInRange("How long do you want the arrow to be? (Between 60 and 100 cm)", 60, 100);
                return length;
            }
        }
    }
}