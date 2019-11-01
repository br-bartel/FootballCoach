using System;
using System.Collections.Generic;
using System.Text;

namespace FootballCoach
{
    class Game
    {
        public static void StartGame()
        {
            string compTeam = CompName();
            Console.WriteLine("Welcome, Football Coach! \n\nPlease enter a team name: \n");
            string playerTeam = Console.ReadLine();
            Console.WriteLine($"\nAre you ready to lead the {playerTeam} to victory against the {compTeam}?");
        }

        public static string CompName()
        {
            List<string> nflTeams = new List<string>() {"Cardinals", "Falcons", "Ravens", "Bills", "Panthers",
                                                        "Bengals", "Bears", "Browns", "Cowboys", "Broncos",
                                                        "Lions", "Packers", "Texans", "Colts", "Jaguars",
                                                        "Chiefs", "Chargers", "Rams", "Dolphins", "Vikings", "Patriots",
                                                        "Saints", "Giants", "Jets", "Raiders", "Eagles", "Steelers",
                                                        "49ers", "Seahawks", "Buccaneers", "Titans", "Redskins"};

            Random rand = new Random();

            string team = nflTeams[rand.Next(0, 32)];

            return team;
        }

    }
}
