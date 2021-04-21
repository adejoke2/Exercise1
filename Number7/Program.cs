using System;

namespace Number7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number:  ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:  ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            Console.WriteLine(sum);      
        }
    }
}
