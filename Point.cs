using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    // Класс Point представляет точку в двумерном пространстве
    internal class Point
    {
        // Свойства для координат точки
        public double X { get; set; }
        public double Y { get; set; }

        // Конструктор по умолчанию создает точку (0,0)
        // Конструктор с параметрами позволяет задать координаты точки
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
    }
}
