using System;

namespace FootballCoach
{
    class Field // will contain scores for each team, down and distance, quarter and time remaining, and anything else corresponding to the gamestate
    {
        public static int PlayerScore { get; set; }

        public static int CompScore { get; set; }

        public static string DownNumber { get; set; } // first, second, third, and fourth

        public static int DistToGo { get; set; } // will start at 10, will decrease or increase based on play results

        public static int FieldPosition { get; set; } // will be 0 - 100, <0 is safety, >100 is touchdown
        
        internal static void Scoreboard()
        {
            PlayerScore = 49; // placeholder
            CompScore = 35; // placeholder
            FieldPosition = 51; // placeholder

            string fieldPosition = FieldPosition <= 50 ? $"< {FieldPosition}" : $"{100 - FieldPosition} >"; // adjusts so that the readout points to side of field
                                                                                                            // player is going left to right on offense
            Console.Clear(); // clear and update the entire console each play

            Console.WriteLine($"{Game.PlayerTeam}: {PlayerScore} \n{Game.CompTeam}: {CompScore}\n");
            Console.WriteLine($"{DownNumber} & {DistToGo}");
            Console.WriteLine($"{fieldPosition} yard line"); // gets field position
            Console.WriteLine("Quart & 15:00\n"); // use total elapsed time and if statement for qurter and time left ??
            
            //if (Game.Ready == true)
            //{
                
            //}
        }
    }
}
