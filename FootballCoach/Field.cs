using System;
using System.Collections.Generic;

namespace FootballCoach
{
    class Field // will contain scores for each team, down and distance, quarter and time remaining, and anything else corresponding to the gamestate
    {
        public static int PlayerScore { get; set; }

        public static int CompScore { get; set; }

        public static string DownNumber { get; set; } // first, second, third, and fourth

        public static List<string> downs = new List<string> { "1st", "2nd", "3rd", "4th" };
        public static int DistToGo { get; set; } // will start at 10, will decrease or increase based on play results

        public static int FieldPosition { get; set; } // will be 0 - 100, <0 is safety, >100 is touchdown
        
        internal static void Scoreboard()
        {
            FieldPosition = Plays.random.Next(1, 40); // ball will be placed randomly
            DistToGo = 10;

            for (int i = 0; i < 4; i++) // goes through 4 downs
            {             
                DownNumber = downs[i]; // placeholder

                StatScore();

                PlayCall.Play();

                if (Plays.Turnover == true)
                {
                    Console.WriteLine("There was a turnover on the play");
                    Console.ReadKey();
                    break;
                }

                DistToGo -= Plays.YardsGained;
                
                if (DistToGo <= 0)
                {
                    i = -1; // sets so the iterator will be at 0 for next pass (0 index is 1st down)
                    DistToGo = 10; // resets down distance
                }
                
                FieldPosition += Plays.YardsGained; // updates based on the stored value of yards gained
                
                if (FieldPosition >= 100) // if the ball goes into the "endzone"
                {
                    Console.WriteLine("\nTOUCHDOWN!!!");
                    Console.ReadKey();
                    PlayerScore += 7;
                    break;
                }
                else if (FieldPosition >= 90) // within 10 yds of the endzone
                {
                    DistToGo = 100 - FieldPosition;
                }
                else if (FieldPosition <= 0) // in your own endzone
                {
                    Console.WriteLine("\nSafety :(");
                    CompScore += 2;
                    break;
                }

                if (i == 3 && DistToGo > 0) // if there is still yards left to go on 4th down, notify that the ball was turned over
                    Console.WriteLine("Turnover on Downs");

                Console.ReadKey();
            }

            int oppTurn = Plays.random.Next(0, 4); 

            if (oppTurn < 2) // using a random number, sees what the opponent's drive resulted in
                CompScore += 0;
            else if (oppTurn == 2)
                CompScore += 3;
            else if (oppTurn == 3)
                CompScore += 7;

            if (PlayerScore > 21) // first team over 21 points wins, with a message printed out to match
            {
                Console.WriteLine($"\nThe {Game.PlayerTeam} win! Congrats Coach!");
                Game.Ready = false;
            }            
            else if (CompScore > 21)
            {
                Console.WriteLine($"\nThe {Game.CompTeam} win, and managment is deciding if you really are the best fit for the franchise moving forward...");
                Game.Ready = false;
            }
        }

        public static void StatScore()
        {
            Console.Clear(); // clear and update the entire console each play

            Console.WriteLine($"{Game.PlayerTeam}: {PlayerScore} \n{Game.CompTeam}: {CompScore}\n");

            Console.WriteLine($"{DownNumber} & {DistToGo}");

            string fieldPosition = FieldPosition <= 50 ? $"< {FieldPosition}" : $"{100 - FieldPosition} >"; // adjusts so that the readout points to side of field
            Console.WriteLine($"{fieldPosition} yard line"); // gets field position

            //Console.WriteLine("Quart & 15:00\n"); // use total elapsed time and if statement for qurter and time left ??
            Console.WriteLine($"\nLast play: Gain of {Plays.YardsGained}\n");
        }

        
    }
}
