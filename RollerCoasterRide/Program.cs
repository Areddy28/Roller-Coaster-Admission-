using System;

namespace RollerCoasterRide
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn)
            {

                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                int number = Convert.ToInt32(GetInput("Enter your height in inches: "));



                if (number < 54)
                {
                    Console.WriteLine("You cannout ride the raptor! " + name);
                }
                else if (number > 54)
                {
                    Console.WriteLine("You can rid the Raptor! Get excited!!! " + name);
                }

                goOn = Continue(); 


            }
            //1 Prompt the user to enter his/her height in inches
            //2 Validation if statement to see if he/she is tall enough
            //3 Create a while loop to continue y/n? 





        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }

        public static bool Continue()
        {
            string answer = GetInput("Would you like to continue? y/n");
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand");
                Console.WriteLine("Let's try again.");

                // This is recursion, calling a method inside itself
                return Continue();

            }
        }
    }
}

