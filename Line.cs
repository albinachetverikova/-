using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    // Класс Line представляет линию, состоящую из двух точек
    internal class Line
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        
        public Line(Point startPoint = null, Point endPoint = null)
        {
            StartPoint = startPoint ?? new Point();
            EndPoint = endPoint ?? new Point();
        }
    }
}
