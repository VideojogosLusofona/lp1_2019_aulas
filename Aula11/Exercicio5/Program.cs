using System;
using System.Collections.Generic;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Player> setOfPlayers = new HashSet<Player>();

            setOfPlayers.Add(
                new Player() {
                    Type = PlayerType.Tank, Name = "Ana"});

            setOfPlayers.Add(
                new Player() {
                    Type = PlayerType.Slayer, Name = "Player"});

            setOfPlayers.Add(
                new Player() {
                    Type = PlayerType.Tank, Name = "Ana"});

            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.Type}");
            }
        }
    }
}
