using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    // Класс PolyLine представляет многоугольник, состоящий из серии линий
    internal class PolyLine
    {
        public List<Point> Points { get; set; }
        
        public PolyLine(List<Point> points = null)
        {
            Points = points ?? new List<Point> { new Point() };
        }
        
        // Метод Scale масштабирует многоугольник на заданный коэффициент
        public void Scale(double factor)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i].X *= factor;
                Points[i].Y *= factor;
            }
        }
    }
}
