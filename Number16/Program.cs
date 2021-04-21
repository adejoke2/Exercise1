using System;

namespace Number16
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Input a string : ");
          string str = Console.ReadLine();
   
          Console.WriteLine(test(str));
        }
       public static bool test(string str)
       {
        var put = 0;
        
        for (var i = 0; i < str.Length - 1; i++)
        {
          if (str[i].Equals('x')) put++;

          if (str.Substring(i, 2).Equals("x") && put > 2)
            return true;
        }
          return false;
       
        }
    }
}
