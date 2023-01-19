//Kitt Mori
//January 18 2023
//Mission #2 IS 413

using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //random number generator
            Random r = new Random();

            //output to user welcome message
            Console.WriteLine("Welcome to the dice throwing simulator!\n");

            //ask user to input how many rolls to be simulated
            Console.WriteLine("How many dice rolls would you like to simulate?:  ");

            //take what the user inputted, convert it to an integer and assign value to numRolls
            int numRolls = Int32.Parse(Console.ReadLine());

            //declare an array to keep track of rolls and the counts of each combination
            int[] rollCount = new int[11];

            //use a loop and the number of loops will depend on the number of rolls the user inputted previously
            for (int i = 0; i < numRolls; i++)
            {
                // the variable roll will be assigned an integer which is the sum of two randomly generated numbers between 1 and 6
                int roll = r.Next(1, 7) + r.Next(1, 7);
                // update counter array
                // [roll - 2] is used because the lowest combination possible is 2 and that will be at the first index of the array which is 0.
                // for example, if 6 is rolled, 6 will be at the 4th index (6 - 2 = 4)
                rollCount[roll - 2]++;
            }

            //output information regarding results
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls + ".\n");
            

            //output results
            for (int i = 0; i < 11; i++)
            {
                //calculate number of stars
                int numStars = (rollCount[i] * 100) / numRolls;

                //declare a string called stars which will be used for the output
                string stars = "";

                //use a for loop to create stars string
                for (int j = 0; j < numStars; j++)
                {
                    stars = stars + "*";
                }
                //output
                Console.WriteLine((i + 2) + ": " + stars);
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
