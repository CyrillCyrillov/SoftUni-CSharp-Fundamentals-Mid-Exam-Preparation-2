using System;

namespace Task01_National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeToFinish = 0;
            int peoplesPerHour = 0;
            for (int i = 1; i <= 3; i++)
            {
                peoplesPerHour += int.Parse(Console.ReadLine());
            }

            int people = int.Parse(Console.ReadLine());

            while (people > 0)
            {
                timeToFinish += 1;
                people -= peoplesPerHour;
                if(timeToFinish % 4 == 0)
                {
                    timeToFinish += 1;
                }
            }
            

            Console.WriteLine($"Time needed: {timeToFinish}h.");
        }
    }
}
