﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level26Polymorphism
{
    internal class Sword : InventoryItem
    {
        public Sword() : base(5, 3) { }

        public override string ToString()
        {
            return "Sword";
        }
    }
}
