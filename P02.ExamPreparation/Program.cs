using System;

namespace P02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weakGrade = int.Parse(Console.ReadLine());
            string taskName = string.Empty;
            string lastTask = string.Empty;
            int grade = 0;
            int fails = 0;
            double sumGrades = 0;
            int i = 0;

            while ((taskName = Console.ReadLine()) != "Enough" )
            {
                grade = int.Parse(Console.ReadLine());
                sumGrades += grade;
                if (grade <= 4)
                {
                    fails++;
                    
                    if (fails >= weakGrade)
                    {
                        break;
                    }
                }
                lastTask = taskName;
                i++;
            }
            if (taskName == "Enough")
            {
                Console.WriteLine($"Average score: {sumGrades / i:f2}");
                Console.WriteLine($"Number of problems: {i}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
            else
            {
                Console.WriteLine($"You need a break, {fails} poor grades.");
            }
        }
    }
}
