using System;

namespace Lab_2_Task_1
{
    public class Rectangle
    {
        // Поля для сторін прямокутника
        private double side1;
        private double side2;

        // Конструктор класу
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        // Метод для обчислення площі
        public double CalculateArea()
        {
            return side1 * side2;
        }

        // Метод для обчислення периметра
        public double CalculatePerimeter()
        {
            return 2 * (side1 + side2);
        }

        // Властивість для площі
        public double Area
        {
            get { return CalculateArea(); }
        }

        // Властивість для периметра
        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }
}
