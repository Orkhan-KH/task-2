using System;
using System.Runtime.InteropServices;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = (int)Math.Log10(number) + 1;
            int r;
            int sumOfNumber = 0;
            for (int i = count; i > 0; i--)
            {
                r = number % 10;
                number /= 10;
                sumOfNumber += r * i;
            }
            Console.WriteLine(sumOfNumber);


        }
        
    }
}