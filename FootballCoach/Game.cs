using System;
using System.Collections.Generic;
using System.Text;

namespace FootballCoach
{
    class Game
    {
        public static void StartGame()
        {
            string playerTeam = CompName();
            string compTeam = CompName();

            while (playerTeam == compTeam)
                playerTeam = CompName();
            
            Console.WriteLine($"Welcome, Coach! \n\nAre you ready to lead the {playerTeam} to victory against the {compTeam}?\n");

            bool ready = true;

            do
            {
                // main game play will go here.
            } while (ready == true);
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

        public static void 
    }
}
