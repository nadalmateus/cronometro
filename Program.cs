using System;
using System.IO;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Start();
        }
        static void Start()
        {
            int time = 10;
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

        }
    }
}
