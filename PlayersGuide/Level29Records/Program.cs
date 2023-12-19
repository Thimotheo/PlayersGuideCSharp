namespace Level29Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sword basicSword = new Sword(MaterialType.Iron, GemstoneType.None, 8, 0.25f);
            Sword fancySword = basicSword with { Material = MaterialType.Binarium, Gemstone = GemstoneType.Bitstone };
            Sword redSword = basicSword with { Material = MaterialType.Bronze, Gemstone = GemstoneType.Amber };

            Console.WriteLine(basicSword);
            Console.WriteLine(fancySword);
            Console.WriteLine(redSword);
        }
        public record Sword(MaterialType Material, GemstoneType Gemstone, float Length, float CrossguardWidth);

        public enum MaterialType { Wood, Bronze, Iron, Steel, Binarium }
        public enum GemstoneType { Emerald, Amber, Sapphire, Diamond, Bitstone, None }
    }
}