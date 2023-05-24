using System;

namespace P03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyForTrip = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int days = 0;
            int spend = 0;
            string spendOrSave = string.Empty;
            double spendOrSaveMoney = 0;

            while (money < moneyForTrip)
            {
                spendOrSave = Console.ReadLine();
                spendOrSaveMoney = double.Parse(Console.ReadLine());
                days++;

                if (spendOrSave == "spend")
                {
                    money -= spendOrSaveMoney;
                    spend++;
                    if (money < 0)
                    {
                        money = 0;
                    }
                }
                else if (spendOrSave == "save")
                {
                    money += spendOrSaveMoney;
                    spend = 0;
                }
                if (spend==5)
                {
                    break;
                }
            }

            if (spend == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(days);
            }
            else if (money >= moneyForTrip)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
