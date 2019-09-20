using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearOfBirth;

            Console.WriteLine("Enter your year of birth: ");
            yearOfBirth = Int32.Parse(Console.ReadLine());

            /*if (yearOfBirth % 4 == 0) 
            {
                Console.WriteLine($"{yearOfBirth} was a Leap Year");
            }
            else
            {
                Console.WriteLine($"{ yearOfBirth} was not a Leap Year");
            }
            //Ternary Operator*/

            /*string answer = (yearOfBirth % 4 == 0) ? "Leap Year." : "Not a Leap Year";
            Console.WriteLine(answer);
            Console.ReadLine();*/

            Console.WriteLine("What would be your poison? whisky or wine");
            string userChoise = Console.ReadLine();
            string choise = userChoise == "whisky" ? "Here is your whisky" : "Here is your wine";
            Console.WriteLine(choise);
            Console.WriteLine();
        }


       

    }
}
