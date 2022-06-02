using System;

namespace selection_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favnumber = r.Next(0, 10);
            int userInput;
           
                Console.WriteLine("pick a number 1 - 10");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favnumber)
                {
                    Console.WriteLine($"{userInput} is to low");
                }
                   else if (userInput > favnumber)
                {
                    Console.WriteLine($" {userInput} is to high");
                }
                else
                {
                    Console.WriteLine("you got it right");
                }

            Console.WriteLine("what is your favorite subject");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("i love math");
                    break;
                case "science":
                    Console.WriteLine("science is cool");
                    break;
                case "PE":
                    Console.WriteLine("PE is tiring");
                    break;
                case "reading":
                    Console.WriteLine("reading is boring");
                    break;
                case "history":
                    Console.WriteLine("history is interesting");
                    break;
                    default:
                    Console.WriteLine("i dont know that subject");
                    break ;


            }


        }
    }
}
