using System;
using System.IO;

namespace WriteStuff2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variáveis
            const string filename = "output.txt";
            StreamWriter sw = new StreamWriter(filename);

            // Ler input do utilizador e colocar na queue
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                sw.WriteLine(input);
            }

            // Fechar ficheiro
            sw.Close();

            // Terminar
        }
    }
}
