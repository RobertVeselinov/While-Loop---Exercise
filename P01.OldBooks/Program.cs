using System;

namespace P01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int n = 0;
            string book;
  

            while ((book = Console.ReadLine()) != "No More Books")
            {   
                if (book == favoriteBook)
                {
                    break;
                }
                n++;
            }
            if (book == favoriteBook)
            {
                Console.WriteLine($"You checked {n} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {n} books.");
            }

        }
    }
}
