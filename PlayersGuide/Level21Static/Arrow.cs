using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Level21Static.Arrowhead;
using static Level21Static.Fletching;

namespace Level21Static
{
    public class Arrow
    {
        public ArrowheadType Arrowhead { get; }
        public FletchingType Fletching { get; }
        public float Length { get; }
        public Arrow(ArrowheadType arrowhead, FletchingType fletching, float length)
        {
            Arrowhead = arrowhead;
            Fletching = fletching;
            Length = length;
        }

        public static Arrow CreateEliteArrow()
        {
            return new Arrow(ArrowheadType.Steel, FletchingType.Plastic, 95);
        }

        public static Arrow CreateBeginnerArrow()
        {
            return new Arrow(ArrowheadType.Wood, FletchingType.GooseFeathers, 75);
        }

        public static Arrow CreateMarksmanArrow()
        {
            return new Arrow(ArrowheadType.Steel, FletchingType.GooseFeathers, 65);
        }
        public float GetCost()
        {
            float arrowheadCost = Arrowhead switch
            {
                ArrowheadType.Steel => 10,
                ArrowheadType.Wood => 3,
                ArrowheadType.Obsidian => 5,


            };
            float fletchingCost = Fletching switch
            {
                FletchingType.Plastic => 10,
                FletchingType.TurkeyFeathers => 5,
                FletchingType.GooseFeathers => 3
            };
            float shaftCost = 0.05f * Length;
            return arrowheadCost + fletchingCost + shaftCost;
        }
    }
}
