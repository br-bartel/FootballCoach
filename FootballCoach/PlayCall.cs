using System;

namespace FootballCoach
{
    class PlayCall // this will be the base class for the pass, run, and special teams play call classes
    {
        public static void Play()
        {
            Console.WriteLine("Please choose a play: \n\n1) Run mid \n\n2) Run off \n\n3) Run Outside");
        }
    }
}
