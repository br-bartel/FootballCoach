using System;
using System.Collections.Generic;

namespace FootballCoach
{
    class Game
    {
        public static bool Ready = true;
        public static string PlayerTeam { get; private set; }
        public static string CompTeam { get; private set; }
        public static void StartGame()
        {
            PlayerTeam = TeamName();
            CompTeam = TeamName();

            while (PlayerTeam == CompTeam)
                PlayerTeam = TeamName();

            Console.WriteLine($"Welcome, Coach! \n\nAre you ready to lead the {PlayerTeam} to victory against the {CompTeam}?\n");
            Console.WriteLine("The first team to score more than 21 points wins! \n\nPress the any key to start!");

            Console.ReadKey();
            while (Ready == true)
            {
                Field.Scoreboard();
            }
        }

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
