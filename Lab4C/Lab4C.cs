using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
/*
Class: CSE 1321L
Section: W1 C#
Term: Fall 2022	
Instructor: Jaskirat Singh Sohal
Name: Heather Papp
Lab#: Lab4C 
*/
namespace Lab4C
{
    internal class Lab4C
    {
        static void Main(string[] args)
        {           
            Console.Write("Welcome\nPlease input a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("What would you like to do to this number:\n"
                            + "0 - Get the additive inverse of the number\n"
                            + "1 - Get the reciprocal of the number\n"
                            + "2 - Square the number\n"
                            + "3 - Cube the number\n"
                            + "4 - Exit the program\r\n");
            int selection = int.Parse(Console.ReadLine());
                            
            switch (selection)
            {
                case 0:
                    Console.WriteLine("The additive inverse of " + userInput + " is " (+userInput - 2*userInput+));
                    break;

                case 1:
                    Console.WriteLine("The reciprocal of {0:0.0###} is {1:0.0###}", userInput, 1/userInput);
                    break;

                case 2:
                    Console.WriteLine("The square of {0:0.0###} is {1:0.0###}", userInput, userInput*userInput);
                    break;

                case 3:
                    Console.WriteLine("The cube of {0:0:0###} is {1:0.0###}", userInput, userInput*userInput*userInput);
                    break;

                case 4:
                    Console.WriteLine("Thank you, goodbye!");
                    break;
                default:
                Console.WriteLine("Invalid input, please try again!");
                    break;

                }
            
        }
    }
}