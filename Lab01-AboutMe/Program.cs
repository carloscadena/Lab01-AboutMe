using System;

namespace Lab01_AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quiz about Carlos. This quiz will consist of 5 questions. When you're ready hit enter.");
            Console.ReadLine();
            int total = GetScore();
            Console.WriteLine($"You got {total} out 5 correct. Thanks for playing.");
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
                Console.WriteLine("------------------------------");
                return input;
            }
            else
            {
                Console.WriteLine("Wrong! I guess you don't know me at all. Did you ever care? The correct answer was 4.");
                Console.WriteLine("------------------------------");
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
                Console.WriteLine("------------------------------");
                return true;
            }
            else
            {
                Console.WriteLine("Wrong! Maybe someday.");
                Console.WriteLine("------------------------------");
                return false;
            }
        }

        static string QuestionThree()
        {
            Console.WriteLine("What was the last country I was in, besides the US. It starts with an N and you must spell it correctly.");
            string input = Console.ReadLine().ToLower();
            if (input == "norway")
            {
                Console.WriteLine("You are a great guesser or you have an unhealthy obsession with me.");
                Console.WriteLine("------------------------------");
                return input;
            }
            else
            {
                Console.WriteLine("Wrong! The correct answer was Norway.");
                Console.WriteLine("------------------------------");
                return input;
            }
        }

        static int QuestionFour()
        {
            Console.WriteLine("Do I have a pet?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Wrong! I'll definitely have a dog in the future though.");
                Console.WriteLine("------------------------------");
                return input;
            }
            else
            {
                Console.WriteLine("You're right! Unfortunately. Animals are the best.");
                Console.WriteLine("------------------------------");
                return input;
            }
        }

        static bool QuestionFive()
        {
            Console.WriteLine("True or False, I love ping pong.");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Yes! Who doesn't?");
                Console.WriteLine("------------------------------");
                return true;
            }
            else
            {
                Console.WriteLine("You're way off. Ping pong is the best.");
                Console.WriteLine("------------------------------");
                return false;
            }
        }

        static int GetScore()
        {
            int uno = QuestionOne();
            bool dos = QuestionTwo();
            string tres = QuestionThree();
            int cuatro = QuestionFour();
            bool cinco = QuestionFive();

            string[] userAnswers = { uno.ToString(), dos.ToString(), tres, cuatro.ToString(), cinco.ToString() };
            string[] correctAnswers = { "4", "True", "norway", "2", "True" };
            int score = 0;
            for (int i = 0; i < userAnswers.Length; i++)
            {
                if (userAnswers[i] == correctAnswers[i])
                {
                    score++;
                }
            }
            return score;
        }
    }
}
