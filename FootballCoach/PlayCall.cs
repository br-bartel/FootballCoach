using System;

namespace FootballCoach
{
    /// <summary>
    /// Contains the logic for printing a list of plays and allowing the user to make a choice. 
    /// Provides method calls for the plays as well
    /// </summary>
    class PlayCall
    {
        /// <summary>
        /// Contains the logic for printing a list of plays and allowing the user to make a choice. 
        /// Provides method calls for the plays as well
        /// </summary>
        public static void Play() // the user chooses the play here
        {
            Console.WriteLine("Choose a play: \n\n1) Run Middle    2) Run Off Tackle    3) Run Outside " +
                                             "\n\n4) Short Pass    5) Medium Pass       6) Long Pass \n");

            bool validInput = Int32.TryParse(Console.ReadLine(), out int input); // parses the user input to get an int

            while (validInput == false || input < 1 || input > 7) // if the input isn't an int or the input is outside of the expected bounds, try again
            {
                Console.WriteLine("\nPlease enter a number between 1 and 6");
                validInput = Int32.TryParse(Console.ReadLine(), out input);
            }

            if (Game.PlayerTeam == "Tibouron Sharks") // if the player team is the "cheat team", auto score a touchdown
            {
                Plays.YardsGained = 100 - Field.FieldPosition;
            }

            else // if any other team, call the method corresponding to the user input
            {
                switch (input)
                {
                    case 1:
                        Run.MiddleRun();
                        break;
                    case 2:
                        Run.OffTackleRun();
                        break;
                    case 3:
                        Run.OutsideRun();
                        break;
                    case 4:
                        Pass.ShortPass();
                        break;
                    case 5:
                        Pass.MidPass();
                        break;
                    case 6:
                        Pass.LongPass();
                        break;
                    case 7:
                        Plays.Turnover = true;
                        break;
                    //case 7:
                    //    SpecialTeams.Punt();
                    //    break;
                    //case 8:
                    //    SpecialTeams.FieldGoal();
                    //    break;
                    default:
                        break;
                }
            }

        }
    }
}
