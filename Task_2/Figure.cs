using System;
using System.Collections.Generic;

namespace Lab_2_Task_2
{
    public class Figure
    {
        private List<Point> points;

        // Конструктори, що приймають від 3 до 5 точок
        public Figure(Point point1, Point point2, Point point3)
        {
            points = new List<Point> { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new List<Point> { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new List<Point> { point1, point2, point3, point4, point5 };
        }

        // Метод для обчислення довжини сторони між двома точками
        public double GetSideLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        // Метод для обчислення периметра багатокутника
        public void CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Count; i++)
            {
                Point currentPoint = points[i];
                Point nextPoint = points[(i + 1) % points.Count];
                perimeter += GetSideLength(currentPoint, nextPoint);
            }
            Console.WriteLine($"Периметр багатокутника: {perimeter}");
        }
    }
}