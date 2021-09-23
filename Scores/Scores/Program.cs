using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name:");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();

            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);
            string path = @"C:\Users\david\Desktop\Pitman Training course\C# Basics\Basic-C-Sharp-Projects\Scores\Scores\StudentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double totalScore = 0;
            Console.WriteLine("\nStudent Score: \n");

            foreach(string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                totalScore += score;
            }

            double avgScore = totalScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage Score " + avgScore);

            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
