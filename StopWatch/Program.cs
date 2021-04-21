using System;
using System.Diagnostics;
using System.Threading;

namespace StopW
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWatch myWatch = new MyWatch();

            while (true)
            {
                Console.WriteLine("Enter 'start' to start Stopwatch\nEnter 'stop' to end Stopwach\nEnter any key to exit:\n");
                var input = Console.ReadLine().ToLower();

                if (input == "start" || input == "stop")
                    UseStopwatch(myWatch, input);
                else
                    return;
            }
            
        }
         static void UseStopwatch(MyWatch myWatch, string command)
        {
            switch (command)
            {
                case "start":
                    try
                    { 
                        
                        myWatch.Start();

                    }
                    catch (InvalidOperationException)
                    { 
                        Console.WriteLine("stopWatch is already started\n");
                        
                    }
                    break;
                case "stop":
                    try
                    {
                        myWatch.Stop();
                        Console.WriteLine("Duration: {0}\n", myWatch.GetDuration());
                    }
                    catch (InvalidOperationException)
                    {
                         Console.WriteLine("stopWatch is not started\n");
                    }
                    break;
                default:
                    break;
            }   
        }
    }
}




// Console.WriteLine("Enter start");
            // string word = Console.ReadLine();

                
            // MyWatch.Start();


            // if (word == "start")
            // {
            //     int i;
            //     for (i = 0; i < 1000; i++)
            //     {
            //         System.Threading.Thread.Sleep(10);
            //     }
            //    Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
            // }
            // else
            // {
            //     Console.WriteLine("invalid input");
            // }
