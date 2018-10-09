using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            // get user name

            Console.WriteLine("What's your name? ");
            string userName = Console.ReadLine();

            // user enters in integer btwn 1-100 
            while (true)
            {
                Console.WriteLine("Please enter in a whole number between 1 and 100 or q to quit.");
                string userNumberString = Console.ReadLine();

                try
                {
                    double userNumber = double.Parse(userNumberString);

                    //validate input


                    //comment on the input

                    if (userNumber > 100)
                    {
                        Console.WriteLine("That was not a valid input. Try again.");
                        continue;
                    }

                    else if (userNumber % 2 != 0)
                    {
                        Console.WriteLine(userName + ", " + userNumber + " was odd.");
                    }

                    else if (2 <= userNumber && userNumber < 25)
                    {
                        Console.WriteLine(userName + ", that was even and less than 25");
                    }

                    else if (26 <= userNumber && userNumber <= 60)
                    {
                        Console.WriteLine(userName + ", that was even.");
                    }

                    else if (userNumber > 60)
                    {
                        Console.WriteLine(userName + ", " + userNumber + " was even.");
                    }
               
                   
                    else
                    {
                        continue;
                    }

                }

                catch 
                {

                    if (userNumberString.ToLower() == "q")
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("That was not a valid input. Try again.");
                        continue;
                    }
                }

           
                
                //loop around until 
            }
        }
    }
}
