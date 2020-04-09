using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracao de variaveis
            Stopwatch cron1, cron2;

            // Inicializar cronometros
            cron1 = new Stopwatch();
            cron2 = new Stopwatch();

            cron1.Start();
            Thread.Sleep(1000);

            cron2.Start();
            Thread.Sleep(1000);

            cron1.Stop();
            cron2.Stop();

            Console.WriteLine(
                $"Tempo cron1 = {cron1.ElapsedMilliseconds}");
            Console.WriteLine(
                $"Tempo cron2 = {cron2.ElapsedMilliseconds}");
        }
    }
}
