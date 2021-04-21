using System;

namespace Number15
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Enter first number:  ");
            int n1 = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Enter second number:  ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number:  ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            
            if (n1 >= n2)
            {
                if (1 >= 3)
                {
                   Console.WriteLine("%.2lf is the largest number.", n1);
                }
                   
                else
                {
                    Console.WriteLine("%.2lf is the largest number.", n3);
                }
                   
            }
            else if((n2 >= n3))
            { 
                Console.WriteLine("%.2lf is the largest number.", n2);
            }else
            {
                 Console.WriteLine("%.2lf is the largest number.", n3);
            }
        }
    }
}
