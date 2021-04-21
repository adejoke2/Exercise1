using System;

namespace Number11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int Number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another integer: ");
            int Number2 = Convert.ToInt32(Console.ReadLine());

            int total = Number1 + Number2;

            Console.WriteLine(total);

            if (Number1 == Number2)
            {
                Console.WriteLine(total * 3);
            }
        }
    }
}
