using System;

namespace Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number;

            Console.WriteLine("Enter your first number");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            number2 = Convert.ToInt32(Console.ReadLine());

            number = number1;
            number1 = number2;
            number2 = number;

            Console.WriteLine("First Number: " + number1);
            Console.WriteLine("Second Number: " + number2);
        }
    }
}
