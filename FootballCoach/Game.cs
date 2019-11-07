using System;
using System.Collections.Generic;

namespace FootballCoach
{
    class Game
    {
        /// <summary>
        /// A flag for if the game should continue playing
        /// </summary>
        public static bool Ready = true;

        /// <summary>
        /// A string value containing the name of the user team
        /// </summary>
        public static string PlayerTeam { get; private set; }

        /// <summary>
        /// A string value containing the name of the computer team
        /// </summary>
        public static string CompTeam { get; private set; }

        /// <summary>
        /// Provides the start screen and assigns team names. Also asks for the score the player wants to play to.
        /// </summary>
        public static void StartGame()
        {
            PlayerTeam = TeamName();
            CompTeam = TeamName();

            while (PlayerTeam == CompTeam)
                PlayerTeam = TeamName();

            Player.Roster();

            Console.WriteLine($"Welcome, Coach! \n\nAre you ready to lead the {PlayerTeam} to victory against the {CompTeam}?\n");

            // let the user choose the score to play too
            bool value;
            int maxValue;

            do
            {
                Console.WriteLine("Please enter the score you want to play to (7 - 72):");
                value = Int32.TryParse(Console.ReadLine(), out maxValue);
            } while (value == false || maxValue < 7 || maxValue > 72);

            Console.WriteLine($"\nThe first team to score {maxValue} or more points wins! \n\nPress the any key to start!");

            Console.ReadKey();
            while (Ready == true)
            {
                Field.Scoreboard(maxValue);
            }
        }

        /// <summary>
        /// Contains a list of NFL teams and one cheat team that is chosen randomly.
        /// </summary>
        /// <returns>Team name</returns>
        public static string TeamName()
        {
            List<string> nflTeams = new List<string>() {"Cardinals", "Falcons", "Ravens", "Bills", "Panthers",
                                                        "Bengals", "Bears", "Browns", "Cowboys", "Broncos",
                                                        "Lions", "Packers", "Texans", "Colts", "Jaguars",
                                                        "Chiefs", "Chargers", "Rams", "Dolphins", "Vikings", "Patriots",
                                                        "Saints", "Giants", "Jets", "Raiders", "Eagles", "Steelers",
                                                        "49ers", "Seahawks", "Buccaneers", "Titans", "Redskins", "Tibouron Sharks"};

            Random rand = new Random();

            string team = nflTeams[rand.Next(0, 33)];

            return team;
        }


    }
}
