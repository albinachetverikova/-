using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    // Класс ColoredLine наследуется от Line и добавляет свойство цвета
    internal class ColoredLine : Line
    {
        public string Color { get; set; }
        
        public ColoredLine(Point startPoint = null, Point endPoint = null, string color = "black") : base(startPoint, endPoint)
        {
            Color = color;
        }
    }

}
