using System;

namespace P04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stepsPerDay = string.Empty;
            int stepsPerDay1 = 0;
            int sumSteps = 0;

            while (true)
            {
                stepsPerDay = Console.ReadLine();
                if (stepsPerDay == "Going home")
                {
                    stepsPerDay = Console.ReadLine();
                    stepsPerDay1 = int.Parse(stepsPerDay);
                    if (sumSteps + stepsPerDay1 < 10000)
                    {
                        Console.WriteLine($"{10000 - Math.Abs(sumSteps + stepsPerDay1)} more steps to reach goal.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{Math.Abs(10000 - (sumSteps + stepsPerDay1))} steps over the goal!");
                        break;
                    }
                }
                stepsPerDay1 = int.Parse(stepsPerDay);
                sumSteps += stepsPerDay1;

                if (sumSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{Math.Abs(sumSteps - 10000)} steps over the goal!");
                    break;
                }


            }
        }
    }
}
