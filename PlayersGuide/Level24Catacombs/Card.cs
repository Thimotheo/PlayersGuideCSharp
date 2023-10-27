using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Level24Catacombs.CardColors;
using static Level24Catacombs.CardRanks;

namespace Level24Catacombs
{
    public class Card
    {
        public CardRank Rank { get; }
        public CardColor Color { get; }

        public Card(CardRank rank, CardColor color)
        {
            Rank = rank;
            Color = color;
        }

        public bool isSymbol => Rank == CardRank.DollarSign || Rank == CardRank.PercentSign
            || Rank == CardRank.Caret || Rank == CardRank.Ampersand;
        public bool isNumber => !isSymbol;
    }
}
