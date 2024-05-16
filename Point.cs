using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
// Класс Point представляет точку в двумерном пространстве
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
    }
}
