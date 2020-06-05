using System;
using System.IO;
using System.Collections.Generic;

namespace WriteStuff1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variáveis
            const string filename = "output.txt";
            Queue<string> queue = new Queue<string>();

            // Ler input do utilizador e colocar na queue
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                queue.Enqueue(input);
            }

            // Gravar conteúdos da queue no ficheiro
            File.WriteAllLines(filename, queue);

            // Terminar
        }
    }
}
