using System;

namespace P05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coins = double.Parse(Console.ReadLine())*100;
            int ourCoins = (int)coins;
            int sumAll = 0;

            while (ourCoins > 0)
            {
                if (ourCoins - 200 >= 0)
                {
                    ourCoins -= 200;
                    sumAll++;
                }
                else if (ourCoins - 100 >= 0)
                {
                    ourCoins -= 100;
                    sumAll++;
                }
                else if (ourCoins - 50 >= 0)
                {
                    ourCoins-= 50;
                    sumAll++;
                }
                else if (ourCoins - 20 >=0)
                {
                    ourCoins -= 20;
                    sumAll++;
                }
                else if (ourCoins - 10 >= 0)
                {
                    ourCoins-= 10;
                    sumAll++;
                }
                else if (ourCoins - 5 >=0)
                {
                    ourCoins-= 5;
                    sumAll++;
                }
                else if (ourCoins - 2 >=0)
                {
                    ourCoins-= 2;
                    sumAll++;
                }
                else if (ourCoins - 1 >= 0)
                {
                    ourCoins-= 1;
                    sumAll++;
                }
            }
            Console.WriteLine(sumAll);
        }
    }
}
