using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;
using System.Text.RegularExpressions;

namespace program
{
    class Program
    {
        static void Main()
        {
            Game game = new Game();
            game.ToGame();
        }
    }

    class Game
    {
        List<Player> players;

        public Game()
        {
            players = new List<Player>() { new(new()), new(new()) };
            Random random = new Random();
            for (int i = 0; i < 16; i++)
            {
                players[0].Cards.Add(new(random.Next(1, 5), random.Next(6, 14)));
            }
            for (int i = 0; i < 16; i++)
            {
                players[1].Cards.Add(new(random.Next(1, 5), random.Next(6, 14)));
            }
        }

        public void ToGame()
        {
            List<int> counts = new() { 0, 0 };
            for (int i = 0; i < 16; i++)
            {
                if(players[0].Cards[i].Type > players[1].Cards[i].Type)
                    counts[0]++;
                else
                    counts[1]++;
            }
            if (counts[0] > counts[1])
                Console.WriteLine($"Победил Игорк 1");
            else
                Console.WriteLine($"Победил Игорк 2");
            AnyKey();
        }
    }

    record Player (List<Card> Cards);

    record Card (int Suit, int Type);
}