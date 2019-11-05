using System;
using System.Collections.Generic;
using System.Text;

namespace FootballCoach
{
    class SpecialTeams : Plays
    {
        
        public static void Punt()
        {
            Console.WriteLine("This is a punt");
        }

        public static void FieldGoal()
        {
            Console.WriteLine("This is a Field Goal");
        }
    }
}
