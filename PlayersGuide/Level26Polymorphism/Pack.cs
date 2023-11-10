﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level26Polymorphism
{
    public class Pack
    {
        public int MaxItemCount { get; }
        public float MaxWeight { get; }
        public float MaxVolume { get; }
        private InventoryItem[] _items;
        public Pack(int maxItemCount, float maxWeight, float maxVolume)
        {
            MaxItemCount = maxItemCount;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;

            _items = new InventoryItem[maxItemCount];
        }

        public int CurrentItemCount { get; protected set; }
        public float CurrentWeight { get; protected set; }
        public float CurrentVolume { get; protected set; }

        public bool Add(InventoryItem item)
        {
            if (CurrentItemCount >= MaxItemCount ||
                CurrentVolume + item.Volume > MaxVolume ||
                CurrentWeight + item.Weight > MaxWeight)
                return false;

            _items[CurrentItemCount] = item;
            CurrentItemCount++;
            CurrentWeight += item.Weight;
            CurrentVolume += item.Volume;
            return true;
        }

        public override string ToString()
        {
            string contents = "Pack containing ";
            if (CurrentItemCount == 0) { contents += "Nothing"; }

            for (int itemNumber = 0; itemNumber < CurrentItemCount; itemNumber++)
            {
                contents += _items[itemNumber].ToString() + " ";
            }

            return contents;
        }

    }
}
