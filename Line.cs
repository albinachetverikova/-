using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    // Класс Line представляет линию, состоящую из двух точек
    internal class Line : Point
    {
        // Свойства для начальной и конечной точек линии
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        // Конструктор с параметрами позволяет задать начальную и конечную точки линии

        public Line(Point startPoint = null, Point endPoint = null)
        {
            StartPoint = startPoint ?? new Point();
            EndPoint = endPoint ?? new Point();
        }

        // Метод Rotate изменяет угол поворота линии относительно первой точки
        public void Rotate(double angle)
        {
            // Реализация метода поворота
    }
}
}
