//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

using System.Runtime.Serialization.Formatters;

namespace DZ_6th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', '.', ',').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    count++;
            }
            Console.WriteLine($"{String.Join(", ", array)} -> {count}");
        }
    }
}