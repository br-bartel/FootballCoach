using System;
using System.Collections.Generic;
using System.Text;

namespace FootballCoach
{
    class Game
    {
        public static string PlayerTeam { get; private set; }
        public static string CompTeam { get; private set; }
        public static void StartGame()
        {
            PlayerTeam = CompName();
            CompTeam = CompName();

            while (PlayerTeam == CompTeam)
                PlayerTeam = CompName();

            Console.WriteLine($"Welcome, Coach! \n\nAre you ready to lead the {PlayerTeam} to victory against the {CompTeam}?\n");

            //do
            //{
                
            //} while (ready == true);
        }

        public static string CompName()
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
