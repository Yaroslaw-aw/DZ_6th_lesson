//Задача 43: Напишите программу, которая найдёт точку пересечения двух
//прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

namespace DZ_6th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Input();
           
            double y, x, b1 = numbers.b1, b2 = numbers.b2, k1 = numbers.k1, k2 = numbers.k2;

            x = (b2 - b1) / (k1 - k2);
            y = k1 * (b2 - b1) / (k1 - k2) + b1;

            Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} - > ({x}, {y})");


            // функции:

            (double b1, double k1, double b2, double k2) Input()
            {
                double b1, k1, b2, k2;

                Console.WriteLine($"Введите b1");
                double.TryParse(Console.ReadLine(), out b1);

                Console.WriteLine($"Введите k1");
                double.TryParse(Console.ReadLine(), out k1);

                Console.WriteLine($"Введите b2");
                double.TryParse(Console.ReadLine(), out b2);

                Console.WriteLine($"Введите k2");
                double.TryParse(Console.ReadLine(), out k2);

                return (b1, k1, b2, k2);
            }
        }
    }
}