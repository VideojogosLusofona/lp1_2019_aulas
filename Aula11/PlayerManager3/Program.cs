using System;
using System.Collections.Generic;

namespace PlayerManager3
{
    class Program
    {
        private List<Player> playerList;

        public Program()
        {
            playerList = new List<Player>()
            {
                new Player("Marco", 200),
                new Player("Verde", 250)
            };
        }

        public void Run()
        {
            string input;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("----");
                Console.WriteLine("1. Insert Player");
                Console.WriteLine("2. List all players");
                Console.WriteLine("3. List players with score greater than");
                Console.WriteLine("E. Exit");
                Console.WriteLine();
                Console.Write("> ");
                input = Console.ReadLine().ToUpper();
                switch (input)
                {
                    case "1":
                        InsertPlayer();
                        break;
                    case "2":
                        ShowPlayers(playerList);
                        break;
                    case "3":
                        ShowPlayersWithScore();
                        break;
                    case "E":
                        break;
                    default:
                        Console.WriteLine("!!! Unknown option !!!");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            while (input != "E");
        }

        private void InsertPlayer()
        {
            string name;
            int score;

            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());

            playerList.Add(new Player(name, score));

            playerList.Sort();
        }

        private void ShowPlayers(IEnumerable<Player> playerCollection)
        {
            foreach (Player player in playerCollection)
            {
                Console.WriteLine("-> {0} : {1}",
                    player.Name, player.Score);
            }
        }

        private void ShowPlayersWithScore()
        {
            IEnumerable<Player> highScorePlayers;
            int minScore;
            Console.Write("What's the minimum score? ");
            minScore = Convert.ToInt32(Console.ReadLine());
            highScorePlayers = GetPlayersWithScoreGreaterThan(minScore);
            ShowPlayers(highScorePlayers);
        }

        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            foreach (Player player in playerList)
            {
                if (player.Score >= minScore)
                {
                    yield return player;
                }
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
    }
}
