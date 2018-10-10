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
            QuestionTwo();
            //QuestionThree();
            //Console.WriteLine("Do I have a pet?");
            //QuestionFour();
            //Console.WriteLine("True or False, I love ping pong.");
            //QuestionFive();
        }

        static int QuestionOne()
        {
            Console.WriteLine("On what day in November is my birthday?");
            int input = 0;
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("That doesn't work. You need to take this more seriously.");
            }

            if(input == 4)
            {
                Console.WriteLine("An amazing guess! You got it.");
                return input;
            }
            else
            {
                Console.WriteLine("Wrong! I guess you don't know me at all. Did you ever care? The correct answer was 4.");
                return input;
            }
        }

        static bool QuestionTwo()
        {
            Console.WriteLine("True or False, I've never jumped out of an airplane.");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("You're correct. Jumping out of planes is insane.");
                return true;
            }
            else
            {
                Console.WriteLine("Wrong! Maybe someday.");
                return false;
            }
        }
    }
}
