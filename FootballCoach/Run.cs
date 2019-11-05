﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FootballCoach
{
    class Run : Plays
    {
        public static void MiddleRun()
        {
            Turnover = false;
            int rand = random.Next(0, 101);

            if (rand < 10)
                YardsGained = random.Next(-4, 1);
            else if (rand >= 10 && rand < 30)
                YardsGained = random.Next(1, 4);
            else if (rand >= 30 && rand < 80)
                YardsGained = random.Next(4, 7);
            else if (rand >= 80 && rand < 93)
                YardsGained = random.Next(7, 51);
            else if (rand >= 93 && rand < 98)
                YardsGained = 100 - Field.FieldPosition;
            else
                Turnover = true;
            
            if (!Turnover)
                Console.WriteLine($"\nRun up the middle for {YardsGained} yards");

        }

        public static void OffTackleRun()
        {
            Turnover = false;
            int rand = random.Next(0, 101);

            if (rand < 10)
                YardsGained = random.Next(-4, 1);
            else if (rand >= 10 && rand < 35)
                YardsGained = random.Next(1, 4);
            else if (rand >= 35 && rand < 80)
                YardsGained = random.Next(4, 7);
            else if (rand >= 80 && rand < 90)
                YardsGained = random.Next(7, 64);
            else if (rand >= 90 && rand < 98)
                YardsGained = 100 - Field.FieldPosition;
            else
                Turnover = true;

            if (!Turnover)
                Console.WriteLine($"\nRun off tackle for {YardsGained} yards");
        }

        public static void OutsideRun()
        {
            Turnover = false;
            int rand = random.Next(0, 101);

            if (rand < 15)
                YardsGained = random.Next(-4, 1);
            else if (rand >= 15 && rand < 25)
                YardsGained = random.Next(1, 7);
            else if (rand >= 25 && rand < 75)
                YardsGained = random.Next(7, 17);
            else if (rand >= 75 && rand < 90)
                YardsGained = random.Next(17, 66);
            else if (rand >= 90 && rand < 98)
                YardsGained = 100 - Field.FieldPosition;
            else
                Turnover = true;

            if (!Turnover)
                Console.WriteLine($"\nRun outside for {YardsGained} yards");
        }
    }
}
