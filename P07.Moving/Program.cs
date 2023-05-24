using System;

namespace P07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int freeSpace = x * y * z;
            int cartons = 0;
            string input = string.Empty;

            while (cartons < freeSpace)
            {
                input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                cartons += int.Parse(input);

            }
            if (input == "Done")
            {
                Console.WriteLine($"{freeSpace - cartons} Cubic meters left.");
            }
            else if (freeSpace < cartons)
            {
                Console.WriteLine($"No more free space! You need {cartons - freeSpace} Cubic meters more.");
            }
        }
    }
}
