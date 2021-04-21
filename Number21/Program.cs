using System;

namespace Number21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 3, 0, 4, 6, 2, 3 };

            Array.Sort(numbers);

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
