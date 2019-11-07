using System;

namespace FootballCoach
{
    /// <summary>
    /// The base class for Run and Pass. Contains shared constructors and instantiation for Random
    /// </summary>
    class Plays
    {
        /// <summary>
        /// Used to store the yardage gained on the previous play
        /// </summary>
        internal static int YardsGained { get; set; }

        //internal static bool AutoTD { get; set; }

        /// <summary>
        /// A flag for if a turnover occured on that play
        /// </summary>
        internal static bool Turnover { get; set; }

        /// <summary>
        /// Tracks the number of turnovers in the game
        /// </summary>
        internal static int TurnoverCount { get; set; }
                
        public static Random random = new Random();
    }
}
