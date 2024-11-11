using System;
using System.Numerics;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.Write(args[i]);
            }

            Console.WriteLine("Enter Your Age?");

            string age = Console.ReadLine();

            //int legalage = Convert.ToInt32(age); //throws exception/error if input is not valid number 

            bool checkAge = int.TryParse(age, out int legalage); // more safe method to conversion, no exception/error thrown
            if (checkAge)
            {

                if (legalage >= 18)
                {
                    Console.WriteLine("Congrats You Will have to start working");
                }
                else
                {
                    Console.WriteLine("Shut up and go study kid!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number, not a string!");
            }

            Player user = new Player();
            Console.WriteLine("Enter Player Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Player Health");
            string healthInput = Console.ReadLine();
            int health;
            if (int.TryParse(healthInput, out health))
            {
                user.details(name, health);
            }
            else
            {
                Console.WriteLine("Invalid health input. Please enter a valid number.");
            }

        }
    }
}
