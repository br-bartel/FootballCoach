using System;

namespace FootballCoach
{
    class PlayCall // this will be the base class for the pass, run, and special teams play call classes
    {
        enum PlayTypes
        {
            RunMid = 1, RunOffTackle, RunOutside, PassShort, PassMiddle, PassLong, Punt, FieldGoal,
        }

        internal static int YardsGained { get; set; }

        internal static bool AutoTD { get; set; }

        internal static bool Turnover { get; set; }
        public static void Play()
        {
            Console.WriteLine("Choose a play: \n\n1) Run Middle \n\n2) Run Off Tackle \n\n3) Run Outside \n\n" +
                                              "4) Short Pass\n\n5) Mid Pass \n\n6) Long Pass \n\n7) Punt \n\n8) Field Goal\n");
            
            int playChoice = Console.Read();
        }
    }
}
