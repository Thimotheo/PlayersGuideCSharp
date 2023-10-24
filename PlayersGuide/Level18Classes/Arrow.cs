using Level13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Level18Classes.Arrowhead;
using static Level18Classes.Fletching;

namespace Level18Classes
{
    public class Arrow
    {
        public ArrowheadType _arrowhead;
        public FletchingType _fletching;
        public float _length;

        public Arrow(ArrowheadType arrowhead, FletchingType fletching, float length)
        {
            _arrowhead = arrowhead;
            _fletching = fletching;
            _length = length;
        }
        public float GetCost()
        {
            float arrowheadCost = _arrowhead switch
            {
                ArrowheadType.Steel => 10,
                ArrowheadType.Wood => 3,
                ArrowheadType.Obsidian => 5,


            };
            float fletchingCost = _fletching switch
            {
                FletchingType.Plastic => 10,
                FletchingType.TurkeyFeathers => 5,
                FletchingType.GooseFeathers => 3
            };
            float shaftCost = 0.05f * _length;
            return arrowheadCost + fletchingCost + shaftCost;
        }

    }

}

