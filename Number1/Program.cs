using System;

namespace Number1
{
    class Program
    {
        static void Main(string[] args)
        }     
            Console.Write("Enter the first number to be divided: ");
            int Firstnumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string Operator = Console.ReadLine();


            Console.Write("Enter second number to be divided with: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int Total = Firstnumber/secondNum;
            Console.Write($"The answer is {Total}");
        }
    }
}
