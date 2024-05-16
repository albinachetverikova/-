using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    // Класс PolyLine представляет многоугольник, состоящий из серии линий
    internal class PolyLine:Line
    {
        // Список точек, формирующих многоугольник
        public List<Point> Points { get; set; }

        // Конструктор с параметрами позволяет задать список точек многоугольника
        public PolyLine(List<Point> points = null)
        {
            Points = points ?? new List<Point> { new Point() };
        }

        // Метод Scale масштабирует многоугольник на заданный коэффициент
        public void Scale(double factor)
        {
            // Реализация метода масштабирования
        }
    }
}
