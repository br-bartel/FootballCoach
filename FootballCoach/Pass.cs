using System;

namespace FootballCoach
{
    class Pass : Plays
    {
        /// <summary>
        /// Flag if the result of the play was a sack. 
        /// </summary>
        private static bool Sack { get; set; }

        /// <summary>
        /// Flag if the result of the play was an incomplete pass
        /// </summary>
        private static bool Incomp { get; set; }

        /// <summary>
        /// Tracks the number of completed passes
        /// </summary>
        internal static int Complete { get; private set; } // used for statskeeping

        /// <summary>
        /// Tracks the number of passing attempts, excluding "sacks"
        /// </summary>
        internal static int Attempts { get; private set; } // used for statskeeping

        /// <summary>
        /// Tracks the sum of passing yards over the course of the game.
        /// Sacks are counted against this total
        /// </summary>
        internal static int PassYards { get; private set; } // used for statskeeping
        
        /// <summary>
        /// Using a random value, generates an outcome
        /// simulating a short passing route
        /// </summary>
        internal static void ShortPass()
        {
            int rand = random.Next(0, 101);
            Sack = false;
            Incomp = false;
            Turnover = false;

            if (rand < 20)
            {
                Incomplete();
            }
            else if (rand >= 20 && rand < 55)
            {
                YardsGained = random.Next(0, 7);
                Complete++;
            }
            else if (rand >= 55 && rand < 80)
            {
                YardsGained = random.Next(7, 12);
                Complete++;
            }
            else if (rand >= 80 && rand < 90)
            {
                YardsGained = random.Next(12, 51);
                Complete++;
            }
            else if (rand >= 90 && rand < 94)
            {
                YardsGained = 100 - Field.FieldPosition;
                Complete++;
            }
            else if (rand >= 94 && rand < 97)
            {
                Sacked();
            }
            else
                Turnover = true;
                        
            if (!Turnover && !Sack && !Incomp)
            {
                int caughtBy = Player.Wr1;
                Console.WriteLine($"\n#{Player.Qb1} Short Pass to #{caughtBy} for {YardsGained} yards");
                PassYards += YardsGained;
            }

            if (!Sack && !Turnover)
                Attempts++;
        }
        /// <summary>
        /// Using a random value, generates an outcome
        /// simulating a mid length passing route
        /// </summary>
        internal static void MidPass()
        {
            int rand = random.Next(0, 101);
            Sack = false;
            Incomp = false;
            Turnover = false;

            if (rand < 35)
            {
                Incomplete();
            }
            else if (rand >= 35 && rand < 45)
            {
                YardsGained = random.Next(4, 9);
                Complete++;
            }
            else if (rand >= 45 && rand < 80)
            {
                YardsGained = random.Next(9, 16);
                Complete++;
            }
            else if (rand >= 80 && rand < 90)
            {
                YardsGained = random.Next(16, 66);
                Complete++;
            }
            else if (rand >= 90 && rand < 94)
            {
                YardsGained = 100 - Field.FieldPosition;
                Complete++;
            }
            else if (rand >= 94 && rand < 97)
            {
                Sacked();
            }
            else
                Turnover = true;

            if (!Turnover && !Sack && !Incomp)
            {
                int caughtBy = Player.Te1;
                Console.WriteLine($"\n#{Player.Qb1} Medium Pass to #{caughtBy} for {YardsGained} yards");
                PassYards += YardsGained;
            }

            if (!Sack && !Turnover)
                Attempts++;
        }
        
        /// <summary>
        /// Using a random value, generates an outcome
        /// simulating a long passing route
        /// </summary>
        internal static void LongPass()
        {
            int rand = random.Next(0, 101);
            Sack = false;
            Incomp = false;
            Turnover = false;

            if (rand < 50)
            {
                Incomplete();
            }
            else if (rand >= 50 && rand < 55)
            {
                YardsGained = random.Next(5, 16);
                Complete++;
            }
            else if (rand >= 55 && rand < 65)
            {
                YardsGained = random.Next(16, 26);
                Complete++;
            }
            else if (rand >= 65 && rand < 75)
            {
                YardsGained = random.Next(26, 81);
                Complete++;
            }
            else if (rand >= 75 && rand < 85)
            {
                YardsGained = 100 - Field.FieldPosition;
                Complete++;
            }
            else if (rand >= 85 && rand < 97)
            {
                Sacked();
            }
            else
                Turnover = true;
       
            if (!Turnover && !Sack && !Incomp)
            {
                int caughtBy = Player.Wr2;
                Console.WriteLine($"\n#{Player.Qb1} Long pass to #{caughtBy} for {YardsGained} yards");
                PassYards += YardsGained;
            }

            if (!Sack && !Turnover)
                Attempts++;
        }

        /// <summary>
        /// Generates the result of a "sack", include text and setting YardsGained
        /// </summary>
        private static void Sacked()
        {
            YardsGained = random.Next(-7, -1);
            Sack = true;
            Console.WriteLine($"\n#{Player.Qb1} Sacked for a loss of {YardsGained} yards");
            PassYards += YardsGained;
        }

        /// <summary>
        /// Generates the result of an "incomplete" pass, including text output
        /// </summary>
        private static void Incomplete()
        {
            YardsGained = 0;
            Incomp = true;
            Console.WriteLine("\nIncomplete pass");
        }
    }
}
