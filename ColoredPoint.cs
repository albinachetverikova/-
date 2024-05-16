using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    // Класс ColoredPoint наследуется от Point и добавляет свойство цвета
    internal class ColoredPoint:Point
    {
        // Свойство для цвета точки
        public string Color { get; set; }

        // Конструктор с параметрами позволяет задать координаты и цвет точки
        public ColoredPoint(double x = 0, double y = 0, string color = "black") : base(x, y)
        {
            Color = color;
        }
    }
}
