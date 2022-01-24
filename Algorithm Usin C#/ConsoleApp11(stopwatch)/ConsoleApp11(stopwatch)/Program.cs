using System;
using System.Diagnostics;

namespace ConsoleApp11_stopwatch_
{
    class Program
    {
        static void Main(string[] args)
        {
            //stopwatch() used to calculate the time
            //Header is: using System.Diagnostics;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int sum = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                for (int j = 1; j <= 10000; j++)
                {
                    sum = i + j;
                }
            }
            Console.WriteLine("Sum={0}", sum);

            stopwatch.Stop();
            TimeSpan elapsed_time = stopwatch.Elapsed;
            Console.WriteLine("Elapsed Time is: {0}", elapsed_time);

            //Ouput:
            //Sum = 1010000
            //Elapsed Time is: 00:00:15.7535330

            Console.ReadKey();
        }
    }
}
