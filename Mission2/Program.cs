using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("\nHow many dice rolls would you like to simulate? ");

            int numRolls = int.Parse(Console.ReadLine());

            int[] rolls = new int[13];

            Random random = new Random();

            for (int i = 0; i <= numRolls; i++)
            {
                int roll1 = random.Next(1, 7);
                int roll2 = random.Next(1, 7);
                int total = roll1 + roll2;

                rolls[total]++;
            }

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls + ".\n");

            for (int i = 2; i <= 12; i++)
            {
                Console.Write(i + ": ");

                double percentage = (double)rolls[i] / numRolls * 100;

                for (int j=0; j< percentage; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
