using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy("Loki");
            Console.WriteLine(enemy.GetName());
        }
    }
}
