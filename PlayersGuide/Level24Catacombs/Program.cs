using static Level24Catacombs.CardColors;
using static Level24Catacombs.CardRanks;

namespace Level24Catacombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point();
            //ColorCall();
            Card();
        }

        static void Point()
        {
            Point One = new Point(2, 3);
            Point Two = new Point(-4, 0);

            Console.WriteLine($"({One.XCoordinate}, {One.YCoordinate})");
            Console.WriteLine($"({Two.XCoordinate}, {Two.YCoordinate})");
        }

        static void ColorCall()
        {
            Color random = new Color(180, 180, 180);
            Color blue = Color.Blue;

            Console.WriteLine($"{random}");
            Console.WriteLine($"{blue}");
        }

        static void Card()
        {
            CardColor[] colors = { CardColor.Red, CardColor.Green, CardColor.Blue, CardColor.Yellow };
            CardRank[] ranks = { CardRank.One, CardRank.Two, CardRank.Three, CardRank.Four, CardRank.Five, CardRank.Six, CardRank.Seven, CardRank.Eight, CardRank.Nine, CardRank.Ten, CardRank.DollarSign, CardRank.Caret, CardRank.PercentSign, CardRank.Ampersand };

            foreach (CardColor color in colors)
            {
                foreach (CardRank rank in ranks)
                {
                    Console.WriteLine($"The {color} {rank}");
                }
            }
        }
    }
}