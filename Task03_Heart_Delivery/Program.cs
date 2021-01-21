using System;
using System.Linq;

namespace Task03_Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plases = Console.ReadLine().Split('@', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int cupidPosition = 0;
            int valentinePlaseCounter = 0;
            int failedPlases = plases.Length;
            

            while (true)
            {
                string[] comad = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(comad[0].ToUpper() == "LOVE!")
                {
                    break;
                }

                int jump = int.Parse(comad[1]);
                cupidPosition += jump;
                if(cupidPosition > plases.Length - 1)
                {
                    cupidPosition = 0;
                }

                if(plases[cupidPosition] == 0)
                {
                    Console.WriteLine($"Place {cupidPosition} already had Valentine's day.");
                    continue;
                }

                else
                {
                    
                    plases[cupidPosition] -= 2;
                    if(plases[cupidPosition] <= 0)
                    {
                        plases[cupidPosition] = 0;
                        Console.WriteLine($"Place {cupidPosition} has Valentine's day.");
                        valentinePlaseCounter += 1;
                        failedPlases -= 1;
                    }
                }
            }
            
            Console.WriteLine($"Cupid's last position was {cupidPosition}.");

            if(plases.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedPlases} places.");
            }
        }
    }
}
