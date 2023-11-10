﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level26Polymorphism
{
    internal class Food : InventoryItem
    {
        public Food() : base(1, 0.5f) { }

        public override string ToString()
        {
            return "Food";
        }
    }
}
