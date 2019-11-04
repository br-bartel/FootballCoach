using System;

namespace FootballCoach
{
    class Display // will contain scores for each team, down and distance, quarter and time remaining, and anything else corresponding to the gamestate
    {
        public static int PlayerScore { get; set; }

        public static int CompScore { get; set; }
        internal static void Scoreboard()
        {            
            Console.Clear();
            Console.WriteLine($"{Game.PlayerTeam}: {PlayerScore} \n{Game.CompTeam}: {CompScore}\n");
            Console.WriteLine("Down & Dist");
            Console.WriteLine("Quart & 00:00\n");
        }
    }
}
