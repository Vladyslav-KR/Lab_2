using System;

namespace Lab_2_Task_2
{
    public class Point
    {
        // Поля для координат та назви точки
        private double x;
        private double y;
        private string name;

        // Конструктор класу
        public Point(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        // Властивості для координат та назви
        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
