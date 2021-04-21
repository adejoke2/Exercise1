using System;

namespace Number10
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine(Number(2034));
        }
        public static int Number(int name)
        {
            int NumberLength = 0;

            if(NumberLength == 1)
            {
                Console.WriteLine(name.IndexOf(0, 1) > 1);
            }else
            {
                Console.WriteLine(name);
            }
        }
    }
}
