using System;

namespace FootballCoach
{
    /// <summary>
    /// Generates a basic roster for the user team. Used for text outputs.
    /// </summary>
    class Player
    {
        public static int Qb1 { get; private set; }

        public static int Rb1 { get; private set; }

        public static int Rb2 { get; private set; }

        public static int Wr1 { get; private set; }

        public static int Wr2 { get; private set; }

        public static int Te1 { get; private set; }

        static readonly Random random = new Random();

        public static void Roster()
        {
            Qb1 = random.Next(1, 13);

            Rb1 = random.Next(20, 30);

            Rb2 = random.Next(30, 40);

            Wr1 = random.Next(13, 20);

            Wr2 = random.Next(80, 85);

            Te1 = random.Next(85, 90);
        }
    }
}
