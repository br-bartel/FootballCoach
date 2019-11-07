using System;
using System.Collections.Generic;

namespace FootballCoach
{
    /// <summary>
    /// Contains scores for each team, down and distance, quarter and time remaining, and anything else corresponding to the gamestate
    /// </summary>
    class Field  
    {
        /// <summary>
        /// Tracks the player score for checking against win conditions and display
        /// </summary>
        public static int PlayerScore { get; private set; }

        /// <summary>
        /// Tracks the computer score for checking against win conditions and display
        /// </summary>
        public static int CompScore { get; private set; }

        public static string DownNumber { get; private set; } // first, second, third, and fourth

        public static List<string> downs = new List<string> { "1st", "2nd", "3rd", "4th" }; // in the for loop below, these will be called to print the down

        /// <summary>
        /// Tracks the distance needed to get a first down. Will change after each play
        /// </summary>
        public static int DistToGo { get; set; }

        /// <summary>
        /// A value that corresponds to the current field position
        /// </summary>
        public static int FieldPosition { get; set; } // will be 0 - 100, <0 is safety, >100 is touchdown

        /// <summary>
        /// Plays the game up until maxValue has been met or exceeded. Includes methods for both user and computer turns
        /// </summary>
        /// <param name="maxValue"></param>
        internal static void Scoreboard(int maxValue)
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
                    Plays.TurnoverCount++;
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

            if (Plays.Turnover == true)
                CompTurn();

            if (PlayerScore >= maxValue) // first team over 21 points wins, with a message printed out to match            
                PlayerWin();

            if (Plays.Turnover == false)
                CompTurn();

            if (CompScore >= maxValue)
                PlayerLoss();

        }
        /// <summary>
        /// Provides the "Scoreboard" text
        /// </summary>
        public static void StatScore()
        {
            Console.Clear(); // clear and update the entire console each play

            Console.WriteLine($"{Game.PlayerTeam}: {PlayerScore} \n{Game.CompTeam}: {CompScore}\n");

            Console.WriteLine($"{DownNumber} & {DistToGo}");

            string fieldPosition = FieldPosition <= 50 ? $"<= {FieldPosition}" : $"{100 - FieldPosition} =>"; // adjusts so that the readout points to side of field
            Console.WriteLine($"{fieldPosition} yard line"); // gets field position

            //Console.WriteLine("Quart & 15:00\n"); // use total elapsed time and if statement for qurter and time left ??
            Console.WriteLine($"\nLast play: Gain of {Plays.YardsGained}");
            Console.WriteLine($"Rushing: {Run.RushYards} yards \nPassing: {Pass.PassYards} yards\n");
        }

        /// <summary>
        /// Prints the results page with text for a player win
        /// </summary>
        public static void PlayerWin()
        {
            Console.Clear();
            Console.WriteLine($"The {Game.PlayerTeam} win! Congrats Coach!\n");
            Console.WriteLine($"{Game.PlayerTeam}: {PlayerScore} \n{Game.CompTeam}: {CompScore}\n");
            Console.WriteLine($"Final {Game.PlayerTeam} Stats: \n\nRushing Yards: {Run.RushYards} \nPassing Yards: {Pass.PassYards} " +
                            $"\nTotal Offense: {Run.RushYards + Pass.PassYards}" +
                            $"\nTurnovers: {Plays.TurnoverCount}");
            Console.ReadKey();

            Game.Ready = false;
        }

        /// <summary>
        /// Prints the results page with text for a player loss
        /// </summary>
        public static void PlayerLoss()
        {
            Console.Clear();
            Console.WriteLine($"\nThe {Game.CompTeam} win, and managment is deciding if you really are the best fit for the franchise moving forward...");
            Console.WriteLine($"\n{Game.PlayerTeam}: {PlayerScore} \n{Game.CompTeam}: {CompScore}\n");
            Console.WriteLine($"Final {Game.PlayerTeam} Stats: \n\nRushing Yards: {Run.RushYards} \nPassing Yards: {Pass.PassYards} " +
                $"\nTotal Offense: {Run.RushYards + Pass.PassYards}" +
                $"\nTurnovers: {Plays.TurnoverCount}");

            Console.ReadKey();

            Game.Ready = false;
        }

         /// <summary>
         /// Randomly generates a result for the opponents "turn"
         /// </summary>
        public static void CompTurn()
        {
            int oppTurn = Plays.random.Next(0, 4);
            if (Game.CompTeam == "Tibouron Sharks") // will have the opponent score a TD everytime
                CompScore += 7;
            else if (oppTurn < 2) // using a random number, sees what the opponent's drive resulted in
                CompScore += 0;
            else if (oppTurn == 2)
                CompScore += 3;
            else if (oppTurn == 3)
                CompScore += 7;
        }

    }
}
