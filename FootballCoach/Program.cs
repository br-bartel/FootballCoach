using System;

namespace FootballCoach
{
    class Program
    {
        /// <summary>
        /// The entrance to the game.
        /// </summary>
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Game.StartGame();            
        }
    }
}
