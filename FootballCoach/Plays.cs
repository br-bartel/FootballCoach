using System;
using System.Collections.Generic;
using System.Text;

namespace FootballCoach
{
    class Plays
    {
        internal static int YardsGained { get; set; }

        internal static bool AutoTD { get; set; }

        internal static bool Turnover { get; set; }

        public static Random random = new Random();
    }
}
