using System;

namespace Factorial
{
    internal class Homework2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, факториал которого нужно вычислить");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Факториал {number}: {Factorial(number)}");
        }

        static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}
