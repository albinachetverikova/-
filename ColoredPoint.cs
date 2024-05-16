using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    // Класс ColoredPoint наследуется от Point и добавляет свойство цвета
    internal class ColoredPoint : Point
    {
        public string Color { get; set; }
        
        public ColoredPoint(double x = 0, double y = 0, string color = "black") : base(x, y)
        {
            Color = color;
        }
    }
}
