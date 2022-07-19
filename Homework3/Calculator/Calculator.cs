using System;

namespace DZ3
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 число");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знак арифметической операции");
            switch (Console.ReadLine())
            {
                case "+":
                    {
                        Console.WriteLine($"Результат выражения {firstNumber} + {secondNumber} : {firstNumber + secondNumber}");
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine($"Результат выражения {firstNumber} - {secondNumber} : {firstNumber - secondNumber}");
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine($"Результат выражения {firstNumber} / {secondNumber} : {firstNumber / secondNumber}");
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine($"Результат выражения {firstNumber} * {secondNumber} : {firstNumber * secondNumber}");
                        break;
                    }
                case "^":
                    {
                        Console.WriteLine($"Результат выражения {firstNumber} ^ {secondNumber} : {Math.Pow(firstNumber, secondNumber)}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Неизвестная математическая операция");
                        break;
                    }
            }
        }
    }
}