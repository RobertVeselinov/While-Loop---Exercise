using System;

namespace P06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int takenPieces = 0;
            string takenPieces1 = string.Empty;
            int pieces = x * y;

            while ( takenPieces < pieces)
            {
                takenPieces1 = Console.ReadLine();
                if (takenPieces1 == "STOP")
                {
                    break;
                }

                takenPieces += int.Parse(takenPieces1);
            }
            if (takenPieces > pieces)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(takenPieces - pieces)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(pieces - takenPieces)} pieces are left.");
            }
        }
    }
}
