using System;

namespace Number13
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "I seek your refuge yaa Allah";

            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

            string Letter = "";

            int check = 0;

            foreach (string Land in words)
            {
                if (world.Length > check)
                {
                    Letter = Land;

                    check = Land.Length;
                }
            }
        
            Console.WriteLine(Letter);
        }
    }
}
