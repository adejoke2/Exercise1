using System;

namespace Number3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter any value");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("{0}*{1} = {2}", num, i, num*i);
            }
        }
    }
}
