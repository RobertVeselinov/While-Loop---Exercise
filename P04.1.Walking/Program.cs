using System;

namespace P04._1.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsPerDay = 0;
            string input = string.Empty;
            int sumSteps = 0;

            while (sumSteps < 10000)
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    sumSteps += int.Parse(Console.ReadLine());
                    break;
                }
                sumSteps += int.Parse(input);
            }
            if (sumSteps < 10000)
            {
                Console.WriteLine($"{10000 - sumSteps} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{sumSteps - 10000} steps over the goal!");
            }
        }
    }
}
