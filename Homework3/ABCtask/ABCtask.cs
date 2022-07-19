using System;

namespace ABCtask
{
    internal class ABCtask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            int aNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int bNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int cNumber = int.Parse(Console.ReadLine());
            if (aNumber >= 100 && bNumber >= 100)
            {
                Console.WriteLine("Числа А и Б больше 100");
            }

            if ((aNumber % 2 == 0 && bNumber % 2 != 0) || (bNumber % 2 == 0 && aNumber % 2 != 0))
            {
                Console.WriteLine("Только одно из чисел А и Б четное");
            }

            if ((aNumber > 0 && bNumber < 0) || (bNumber > 0 && aNumber < 0))
            {
                Console.WriteLine("Одно из чисел А и Б положительное");
            }

            if (aNumber % 3 == 0 && bNumber % 3 == 0 && cNumber % 3 == 0)
            {
                Console.WriteLine("Каждое из чисел А Б и С кратно трем");
            }

            if ((aNumber < 50 && bNumber > 50 && cNumber > 50) || (aNumber > 50 && bNumber < 50 && cNumber > 50) || (aNumber > 50 && bNumber > 50 && cNumber < 50)) 
            {
                Console.WriteLine("Только одно из чисел А Б и С меньше 50");
            }

            if (aNumber < 0 || bNumber < 0 || cNumber < 0)
            {
                Console.WriteLine("Одно из чисел A Б или С отрицательное");
            }
        }
    }
}
