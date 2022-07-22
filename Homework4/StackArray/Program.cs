using System;
using System.Collections;

namespace Homework4
{
    internal class StackArray
    {
        static void Main(string[] args)
        {

            var rand = new Random();
            var array = new int[rand.Next(2, 15)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }

            var stack = new Stack(array);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
