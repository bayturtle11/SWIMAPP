using System;
using System.Collections.Generic;

namespace SWIMAPP
{
    class Program
    {
        //gobal verible
        static List<string> teamA = new List<string>();
        static List<string> teamB = new List<string>();
        static List<string> teamReserves = new List<string>();

        static void Oneswimmer()
        {
            Console.WriteLine("enter the swimmers name");

            string swimerName = Console.ReadLine();

            Console.WriteLine($"Swimmer name: {swimerName}");

            int sumTotalTime = 0;

            //loop four times
            for (int i = 0; i < 4; i++)
            {

                int mintes, secends, totalTime = 0;

                //generat a random number between 1 and 4 (incl)
                Random randNumber = new Random();
                mintes = randNumber.Next(1, 4);
                secends = randNumber.Next(0, 59);

                totalTime = (mintes * 60) + secends;

                Console.WriteLine($"swimmer Time{ i + 1}:{mintes} min {secends} secends\n total time in seconds:{totalTime}s");

                sumTotalTime = sumTotalTime + totalTime;
            }

            float avgTime = (float)sumTotalTime / 4;

            //assigan swimmer to a team
            if (avgTime <= 160)
            {
                teamA.Add(swimerName);
            }
            else if (avgTime <= 210)
            {
                teamB.Add(swimerName);
            }
            else
            {
                teamReserves.Add(swimerName);
            }

            Console.WriteLine($"avg time: {avgTime}");

        }


        static void Main(string[] args)
        {
            Oneswimmer();
        }
    }
}
