using System;

namespace Number6
{
    class Program
    {
        static void Main(string[] args)
        {
           MultiplicationTable();
        }
  
        static void MultiplicationTable()
        {
            for(int y = 1; y <= 12; y++)
            {
              const int multiplyBy = 3;

              Console.WriteLine($"multiplyBy *{multiplyBy * y }");
            }
        }
    }
}
