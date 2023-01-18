using System;

namespace Mission2assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // made two arrays, one for the roll totals and one for the sum of the times we rolled that total
            Random r = new Random();
            int[] rollamount = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] totalrolls = new int[11];

            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many throws?: ");
            string throws = Console.ReadLine();
            // turn the throws from a string into an integer
            int ithrows = Int32.Parse(throws);

            Console.WriteLine("");

            //for the number of throws the user wants to throw, roll two die (add one because it starts at 0 and goes to 5 and we need 6) and then add them together
            for (int i = 0; i < ithrows; i++)
            {
                int num1 = r.Next(0, 6) + 1;
                int num2 = r.Next(0, 6) + 1;
                int newNum = num1 + num2;

                //find the sum of the rolls and add one time for the time it was just rolled
                totalrolls[newNum - 2] = totalrolls[newNum - 2] + 1;
            }

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Total of " + rollamount[i] + ": " + totalrolls[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS: ");
            Console.WriteLine("");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + ithrows);
            Console.WriteLine("");

            //for each sum amount find the percentage of rolls total and print an astrick for each 1% of the total that it exists
            for (int k = 0; k < rollamount.Length; k++)
            {
                double throwing = totalrolls[k] / (double)ithrows;
                int wholethrows = (int)(throwing * 100);
                string stars = "";
                for (int i = 0; i < wholethrows; i++)
                {
                    stars += "*";
                }
                Console.WriteLine(rollamount[k] + ": " + stars);
            }

            Console.WriteLine("");
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");


            



        }
    }
}
