using System;

namespace FootballCoach
{
    class PlayCall
    {        
        public static void Play() // the user chooses the play here
        {
            Console.WriteLine("Choose a play: \n\n1) Run Middle \n\n2) Run Off Tackle \n\n3) Run Outside \n\n" +
                              "4) Short Pass\n\n5) Mid Pass \n\n6) Long Pass \n");

            bool validInput = Int32.TryParse(Console.ReadLine(), out int input); // parses the user input to get an int

            while (validInput == false || input < 1 || input >
                7) // if the input isn't an int or the input is outside of the expected bounds, try again
            {
                Console.WriteLine("\nPlease enter a number between 1 and 6");
                validInput = Int32.TryParse(Console.ReadLine(), out input);
            }
            
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
