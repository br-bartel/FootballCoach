using System;
using System.Collections.Generic;
using System.Text;

namespace FootballCoach
{
    class Pass : Plays
    {
        private static bool Sack { get; set; }

        private static bool Incomp { get; set; }
        internal static void ShortPass()
        {
            int rand = random.Next(0, 101);
            Sack = false;
            Incomp = false;

            if (rand < 20)
            {
                YardsGained = 0;
                Incomp = true;
            }
            else if (rand >= 20 && rand < 55)
            {
                YardsGained = random.Next(0, 7);
            }
            else if (rand >= 55 && rand < 80)
            {
                YardsGained = random.Next(7, 12);
            }
            else if (rand >= 80 && rand < 90)
            {
                YardsGained = random.Next(12, 51);
            }
            else if (rand >= 90 && rand < 94)
            {
                YardsGained = 100 - Field.FieldPosition;
            }
            else if (rand >= 94 && rand < 97)
            {
                YardsGained = random.Next(-7, -1);
                Sack = true;
            }
            else
                Turnover = true;

            if (Sack == true)
                Console.WriteLine($"\nSacked for a loss of {YardsGained} yards");
            else if (Incomp == true)
                Console.WriteLine("\nIncomplete pass");
            else if (!Turnover)
                Console.WriteLine($"\nShort Pass for {YardsGained} yards");
        }

        internal static void MidPass()
        {
            int rand = random.Next(0, 101);
            Sack = false;
            Incomp = false;

            if (rand < 35)
            {
                YardsGained = 0;
                Incomp = true;
            }
            else if (rand >= 35 && rand < 45)
            {
                YardsGained = random.Next(4, 9);
            }
            else if (rand >= 45 && rand < 80)
            {
                YardsGained = random.Next(9, 16);
            }
            else if (rand >= 80 && rand < 90)
            {
                YardsGained = random.Next(16, 66);
            }
            else if (rand >= 90 && rand < 94)
            {
                YardsGained = 100 - Field.FieldPosition;
            }
            else if (rand >= 94 && rand < 97)
            {
                YardsGained = random.Next(-7, -1);
                Sack = true;
            }
            else
                Turnover = true;

            if (Sack == true)
                Console.WriteLine($"\nSacked for a loss of {YardsGained} yards");
            else if (Incomp == true)
                Console.WriteLine("\nIncomplete pass");
            else
                Console.WriteLine($"\nMedium Pass for {YardsGained} yards");
        }

        internal static void LongPass()
        {
            int rand = random.Next(0, 101);
            Sack = false;
            Incomp = false;

            if (rand < 50)
            {
                YardsGained = 0;
                Incomp = true;
            }
            else if (rand >= 50 && rand < 55)
            {
                YardsGained = random.Next(5, 16);
            }
            else if (rand >= 55 && rand < 65)
            {
                YardsGained = random.Next(16, 26);
            }
            else if (rand >= 65 && rand < 75)
            {
                YardsGained = random.Next(26, 81);
            }
            else if (rand >= 75 && rand < 85)
            {
                YardsGained = 100 - Field.FieldPosition;
            }
            else if (rand >= 85 && rand < 97)
            {
                YardsGained = random.Next(-7, -1);
                Sack = true;
            }
            else
                Turnover = true;

            if (Sack == true)
                Console.WriteLine($"\nSacked for a loss of {YardsGained} yards");
            else if (Incomp == true)
                Console.WriteLine("\nIncomplete pass");
            else
                Console.WriteLine($"\nLong pass for {YardsGained} yards");
           
        }
    }
}
