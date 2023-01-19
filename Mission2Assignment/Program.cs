using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            // establishes array to store how many times a value was rolled
            int[] roll_value = new int[13];
            // Asks user how many times to roll the dice
            Console.Write("How many times should the dice be rolled?  ");
            int num_rolls = int.Parse(Console.ReadLine());
            
            // similuate the roll of the die
            for (int i = 0; i < num_rolls; i++)
            {
                int first_die = r.Next(1, 7);
                int second_die = r.Next(1, 7);
            // store the value of the roll in variable named total
                int total = first_die + second_die;
            // increment roll
                roll_value[total]++;
            }
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS \nEach '*' represents 1 % of the total number of rolls. \nTotal number of rolls = " + num_rolls + "\nResults: ");
            // for loop, establish counter, what the counter will go to, and how to increment
            for (int i = 2; i < 13; i++)
            {
                double astrix_count = 100 * roll_value[i]/num_rolls;
                Console.WriteLine($"{i}: " + new string('*', (int)astrix_count));
            }
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
