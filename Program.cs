using ConsoleApp5;
using System;

class Program
{
    static void Main()
    {
        // Создаем точки
        Point point1 = new Point(2, 3);
        Point point2 = new Point(5, 7);

        // Создаем цветные точки
        ColoredPoint coloredPoint1 = new ColoredPoint(1, 1, "red");
        ColoredPoint coloredPoint2 = new ColoredPoint(4, 6, "blue");

        // Создаем линии
        Line line1 = new Line(point1, point2);
        ColoredLine coloredLine2 = new ColoredLine(coloredPoint1, coloredPoint2, "blue");

        // Изменяем угол поворота линии
        double rotationAngle = 30; // в градусах
        line1.Rotate(rotationAngle);
        coloredLine2.Rotate(rotationAngle);

        // Создаем многоугольник
        List<Point> polygonPoints = new List<Point>
        {
            new Point(1, 1),
            new Point(3, 2),
            new Point(4, 4),
            new Point(2, 3)
        };
        PolyLine polygon = new PolyLine(polygonPoints);

        // Масштабируем многоугольник
        double scaleFactor = 1.5;
        polygon.Scale(scaleFactor);

        // Выводим информацию
        Console.WriteLine("Линия 1: начальная точка ({0}, {1}), конечная точка ({2}, {3})",
            line1.StartPoint.X, line1.StartPoint.Y, line1.EndPoint.X, line1.EndPoint.Y);
        Console.WriteLine("Цвет линии 2: {0}", coloredLine2.Color);
        Console.WriteLine("Многоугольник: {0} точек", polygon.Points.Count);
    }
}
