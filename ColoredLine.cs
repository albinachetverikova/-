using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    // Класс ColoredLine наследуется от Line и добавляет свойство цвета 

    internal class ColoredLine:Line
    {
        // Свойство для цвета линии
        public string Color { get; set; }

        // Конструктор с параметрами позволяет задать начальную и конечную точки, а также цвет линии 

        public ColoredLine(Point startPoint = null, Point endPoint = null, string color = "black") : base(startPoint, endPoint)
        {
            Color = color;
        }
    }
}
