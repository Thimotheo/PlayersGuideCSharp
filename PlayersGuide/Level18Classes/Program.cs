

using Extensions;
using static Level18Classes.Arrow;
using static Level18Classes.Arrowhead;
using static Level18Classes.Fletching;

namespace Level18Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrow arrow = GetArrow();
            Console.WriteLine($"This arrow costs {arrow.GetCost()} gold.");

            Arrow GetArrow()
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