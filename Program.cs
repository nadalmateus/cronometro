using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Contar Segundos 10s = 10 segundos");
            Console.WriteLine("M - Contar Minutos 1m = 1 segundos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quando tempo deseja contar?");


            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data[0..^1]);
            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }
            if (time == 0)
            {
                Environment.Exit(0);
            }
            Start(time * multiplier);

        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Fim!");
        }
    }
}
