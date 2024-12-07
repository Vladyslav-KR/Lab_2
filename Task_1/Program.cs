using System;
using System.Text;

namespace Lab_2_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Встановлення кодування для відображення кирилиці
            Console.OutputEncoding = Encoding.UTF8;

            // Введення довжин сторін прямокутника
            Console.WriteLine("Введіть довжину першої сторони прямокутника:");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть довжину другої сторони прямокутника:");
            double side2 = Convert.ToDouble(Console.ReadLine());

            // Створення об'єкта прямокутника
            Rectangle rectangle = new Rectangle(side1, side2);

            // Виведення результатів
            Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
        }
    }
}
