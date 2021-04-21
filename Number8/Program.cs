using System;

namespace Number8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value to convert:  ");
            int celcius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("farenheit {0}", celcius + 273);
          
            Console.WriteLine("kelvin {0}", celcius * 9 / 5 + 32);            

        }
    }
}
