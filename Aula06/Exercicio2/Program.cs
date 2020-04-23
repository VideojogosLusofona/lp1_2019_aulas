using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            int numEnemies;
            Enemy[] enemies;

            // Pedir ao utilizador nº de inimigos
            Console.Write("Insira nº de inimigos: ");
            numEnemies = Convert.ToInt32(Console.ReadLine());

            // Para cada inimigo, pedir ao utilizador o seu nome,
            // criar objeto inimigo e guardá-lo num array
            enemies = new Enemy[numEnemies];

            for (int i = 0; i < numEnemies; i++)
            {
                string name;
                Console.Write($"Insira nome do inimigo #{i}: ");
                name = Console.ReadLine();
                enemies[i] = new Enemy(name);
            }

            // Para cada inimigo, imprimir o seu nome
            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($">>{enemy.GetName()}<<");
            }
        }
    }
}
