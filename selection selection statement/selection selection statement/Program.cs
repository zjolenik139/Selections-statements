using System;

namespace selection_selection_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var r = new Random();
            //var favNumber = r.Next(1, 5);
            //int userInput;
            //var counter = 0;

            //do
            //{
            //    Console.WriteLine("pick a number from 1-1000");
            //    userInput = int.Parse(Console.ReadLine());

            //    if (userInput < favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too low");
            //    }
            //    else if (userInput > favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too high");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You got it!");
            //    }

            //    counter++;

            //    Console.WriteLine($"you have guessed {counter} times");


            //} while (userInput != favNumber);

            //Switch-Case
            Console.WriteLine("What is your favorite subject");

            string subject = Console.ReadLine();
            switch (subject.ToLower())
            {
                case "math":
                case "calculus":
                    Console.WriteLine("I hate math!");
                    break;
                case "science":
                case "Astronomy":
                    Console.WriteLine("I love science!!");
                    break;
                case "history":
                    Console.WriteLine("History always repeats itselft.");
                    break;
                case "PE":
                case "Gym":
                    Console.WriteLine("PE. is the best!");
                    break;
                case "English":
                    Console.WriteLine("English isnt interesting.");
                    break;
                default:
                    Console.WriteLine("idk that subject");
                    break;
                
            }

        }
    }
}
