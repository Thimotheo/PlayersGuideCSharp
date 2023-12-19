using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level30Generics
{
    public class ColoredItem<T>
    {
        public T Item { get; }
        public ConsoleColor Color { get; }

        public ColoredItem(T item, ConsoleColor color)
        {
            Item = item;
            Color = color;
        }

        public void Display()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(Item?.ToString());
        }
    }
}
