using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int freeSpace = x * y * z;
            int sumCartons = 0;
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Done")
            {
                sumCartons += int.Parse(input);

                if (freeSpace <= sumCartons)
                {
                    break;
                }
            }
            if (sumCartons <= freeSpace)
            {
                Console.WriteLine($"{freeSpace - sumCartons} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {sumCartons - freeSpace} Cubic meters more.");
            }
        }
    }
}
