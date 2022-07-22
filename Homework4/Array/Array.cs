using System;
using System.Linq;

namespace Homework4
{
    internal class Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int[] array = new int[int.Parse(Console.ReadLine())];
            int sum = 0;           
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент");
                array[i] = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine($"Сумма элементов с нечетными индексами: {sum}");
            Console.WriteLine($"Минимальный элемент: {array.Min()}");
        }
    }
}
