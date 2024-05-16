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

        // Метод Rotate изменяет угол поворота линии относительно первой точки
        public void Rotate(double angle)
        {
            // Переводим угол из градусов в радианы
            double radians = angle * Math.PI / 180.0;
            
            // Вычисляем изменения координат
            double deltaX = EndPoint.X - StartPoint.X;
            double deltaY = EndPoint.Y - StartPoint.Y;
            
            // Поворачиваем координаты конечной точки
            double rotatedX = deltaX * Math.Cos(radians) - deltaY * Math.Sin(radians);
            double rotatedY = deltaX * Math.Sin(radians) + deltaY * Math.Cos(radians);
            
            // Обновляем координаты конечной точки
            EndPoint.X = StartPoint.X + rotatedX;
            EndPoint.Y = StartPoint.Y + rotatedY;
        }
    }
}
