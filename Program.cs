using System;
using System.Collections.Generic;

namespace Lists_McVey_Cason
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // My list of games
            List<string> games = new List<string>()
            {
                "CS:GO",
                "Halo 3",
                "Boderlands 3",
                "Fifa 22",
                "Minecraft"
            };

            // My other list for otherGames
            string[] otherGames = new string[]
            {
                "Tiny Tina's Wonderlands",
                "Farcry 3"
            };

            // Prints all of the words in games
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Counts all of the words in games
            Console.WriteLine($"\nGames in lists: {games.Count}");

            // Added otherGames list into games list
            games.AddRange(otherGames);

            // Recount games list
            Console.WriteLine($"\nGames in lists: {games.Count}");

            // To see if Halo is in the list if so, it prints "MASTER CHIEF IS IN THE HOUSE!!" and else adds Halo in the list
            if(games.Contains("Halo"))
            {
                Console.WriteLine("\nMASTER CHIEF IS IN THE HOUSE!!");
            }
            else
            {
                games.Add("Halo");
            }

            // My Integer value
            int myInt = 6;

            // If myInt is less than games if so, remove a game and else prints "Game not found!"
            if(myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("Game not found!");
            }

            // Prints "All games in the list:"
            Console.WriteLine("\nAll games in the list:");

            // Reprints games list
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Sort my game list by alphabetical order
            games.Sort();

            // Prints "Sorted games list:"
            Console.WriteLine("\nSorted games list:");

            // Reprints games list
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // New list
            string[] newList = new string[games.Count];
            
            // Copy games into newList
            games.CopyTo(newList);

            // Clear games list
            games.Clear();

            // Prints "New List:" and reprints game from newList
            Console.WriteLine("\nNew List:");
            foreach (string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}
