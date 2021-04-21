using System;

namespace Number20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int total = year / 100 + 1;

             Console.WriteLine(total);
        }
    }
}
