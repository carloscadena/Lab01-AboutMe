using System;

namespace Lab01_AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quiz about Carlos. This quiz will consist of 5 questions. When you're ready hit enter.");
            Console.ReadLine();
            QuestionOne();
        }
        static void QuestionOne()
        {
            Console.WriteLine("On what day in November is my birthday?");
            int input = int.Parse(Console.ReadLine());
            if(input == 4)
            {
                Console.WriteLine("An amazing guess! You got it.");
            }
            else
            {
                Console.WriteLine("I guess you don't know me at all. Did you ever care?");
            }

        }
    }
}
