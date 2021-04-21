using System;

namespace Number5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word:  ");
            string word = Console.ReadLine();

            string reverseWord = string.Reverse();
            Console.WriteLine($"Reverse Word  : {reverseWord}");
        }
    }
}
