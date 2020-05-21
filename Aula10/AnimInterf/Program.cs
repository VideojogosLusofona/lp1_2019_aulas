using System;

namespace AnimInterf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar array para 10 animais
            Animal[] animals = new Animal[10];

            // Criar instância de Random
            Random rnd = new Random();

            // Colocar 10 animais aleatórios no array
            for (int i = 0; i < 10; i++)
            {
                int anim = rnd.Next(4);

                switch (anim)
                {
                    case 0:
                        animals[i] = new Bat();
                        break;
                    case 1:
                        animals[i] = new Bee();
                        break;
                    case 2:
                        animals[i] = new Cat();
                        break;
                    case 3:
                        animals[i] = new Dog();
                        break;
                }
            }

            // Para cada um dos animais...
            foreach (Animal animal in animals)
            {
                Console.WriteLine("------");
                Console.WriteLine(
                    $"{animal} makes {animal.Sound()}");
                if (animal is IMammal)
                    Console.WriteLine("No of nipples: {0}",
                        (animal as IMammal).NumberOfNipples);
                if (animal is ICanFly)
                    Console.WriteLine("No of wings: {0}",
                        (animal as ICanFly).NumberOfWings);
            }
        }
    }
}
