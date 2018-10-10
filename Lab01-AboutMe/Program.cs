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
            //Console.WriteLine("True or False, I've jumped out of an airplane.");
            //QuestionTwo();
            //Console.WriteLine("What was the last country I was in, besides the US. It starts with an N.");
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
                return 4;
            }
            else
            {
                Console.WriteLine("Wrong! I guess you don't know me at all. Did you ever care? The correct answer was 4.");
                return 4;
            }

        }
        
    }
}
