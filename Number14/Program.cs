﻿using System;

namespace Number14
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Input first integer:");  

           int x = Convert.ToInt32(Console.ReadLine());

           if (x > 0)
           {
              Console.WriteLine(x % 3 == 0 || x % 7 == 0);
           }
        }
    }
}
