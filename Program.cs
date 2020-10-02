using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Decisions_Part_5
{
    class Program
    {

        

        static void EnterToCont()
        {
            Console.WriteLine("Press ENTER to Continue");
            Console.ReadLine();

        }

        static void Grade()
        {
            int grade;

            Console.WriteLine("What was your grade?");
            grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 80 && grade < 101)
            {
                Console.WriteLine("Well done!");
            }

            else if (grade < 80 && grade > 0)
            {
                Console.WriteLine("Study harder next time!");
            }

            else
            {
                Console.WriteLine("HOW?????!");
            }


            EnterToCont();
            Choice();
        }

        static void Guesser()
        {
            int answer;

            Console.WriteLine("Guess the integer that is between 0 and 15 inclusive.");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 12)
            {
                Console.WriteLine($"Well done, you guessed the number, {answer}");
            }

            else if (answer > 15 || answer < 0)
            {
                Console.WriteLine("That's not even in the range!");
            }

            else
            {
                Console.WriteLine("That is incorrct.");
            }


            EnterToCont();
            Choice();

        }

        static void Radius()
        {

            int radius;

            Console.WriteLine("Please input the integer radius");
            radius = Convert.ToInt32(Console.ReadLine());

            if (radius < 0)
            {
                Console.WriteLine("Negative radii are illegal!");
            }

            else if (radius > 0)
            {
                Console.WriteLine($"The diameter is {radius * 2}");
            }

            else
            {
                Console.WriteLine("What you have here is a dot, mate...");
            }

            EnterToCont();
            Choice();
        }

        static void Between()
        {
            int answer;

            Console.WriteLine("Enter an integer that is between 5 and 15");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer > 5 && answer < 15)
            {
                Console.WriteLine("In between");
            }

            else
            {
                Console.WriteLine("Not in between");
            }

            EnterToCont();
            Choice();
        }

        static void Choice()
        {
            int user;
            Console.WriteLine("1 ---> Grade");
            Console.WriteLine("2 ---> Guesser");
            Console.WriteLine("3 ---> Radius");
            Console.WriteLine("4 ---> Between");
            Console.WriteLine("5 ---> Quit");
            user = Convert.ToInt32(Console.ReadLine());

            if (user == 1)
            {
                Grade();
            }
            if (user == 2)
            {
                Guesser();
            }
            if (user == 3)
            {
                Radius();
            }
            if (user == 4)
            {
                Between();
            }
            if (user == 5)
            {
                
            }


        }

        static void Main(string[] args)
        {

            Choice();

        }
    }
}
