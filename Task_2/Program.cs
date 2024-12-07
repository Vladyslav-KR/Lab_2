using System;
using System.Text;

namespace Lab_2_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Встановлення кодування для відображення кирилиці
            Console.OutputEncoding = Encoding.UTF8;

            // Введення даних для точок багатокутника
            Console.WriteLine("Введіть координати точок багатокутника:");

            // Точки трикутника (можна змінити кількість точок)
            Console.WriteLine("Введіть координати точки 1 (x y назва):");
            string[] input1 = Console.ReadLine().Split();
            Point point1 = new Point(Convert.ToDouble(input1[0]), Convert.ToDouble(input1[1]), input1[2]);

            Console.WriteLine("Введіть координати точки 2 (x y назва):");
            string[] input2 = Console.ReadLine().Split();
            Point point2 = new Point(Convert.ToDouble(input2[0]), Convert.ToDouble(input2[1]), input2[2]);

            Console.WriteLine("Введіть координати точки 3 (x y назва):");
            string[] input3 = Console.ReadLine().Split();
            Point point3 = new Point(Convert.ToDouble(input3[0]), Convert.ToDouble(input3[1]), input3[2]);

            // Створення багатокутника
            Figure figure = new Figure(point1, point2, point3);

            // Виведення периметра
            figure.CalculatePerimeter();
        }
    }
}
