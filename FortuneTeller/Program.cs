using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args) {

            //Fortune Teller app

            //Due: Tuesday, February 14th by 5:30 PM
            //Goal: To develop a console application that will tell the user’s fortune based on data received from the user


            // Part 1: Ask the user for the user’s first and last name, age, birth month, favorite color, and number of siblings

            //asking for name
            Console.WriteLine("Hello! Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();


            //asking for age
            Console.WriteLine("How old are you? ");
            int age = int.Parse(Console.ReadLine());


            //asking for birth month
            Console.WriteLine("Enter the number of your birth month: ");
            string month = Console.ReadLine();

            switch (month)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "11":
                case "12":
                    int.Parse(month);
                    break;
            }


            //asking for favorite color
            Console.WriteLine("What is your favorite ROYGBIV color? Type HELP if you don't know. ");
            string favColor = Console.ReadLine();
            favColor.ToLower();

                switch (favColor)
                {
                    case "red":
                    case "orange":
                    case "yellow":
                    case "green":
                    case "blue":
                    case "indigo":
                    case "purple":
                    case "violet":
                        favColor = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("ROYGBIV stands for red, orange, yellow, green, blue, indigo, and violet. Please spell out your favorite color from this list: ");
                        favColor = Console.ReadLine();
                        break;
                }

            //asking for number of siblings
            Console.WriteLine("How many siblings do you have? ");
            int numOfSiblings = int.Parse(Console.ReadLine());



            //Part 2
            // If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an even number.
            int retire;
            if (age % 2 == 0)
            {
                retire = 20; 
            }
            else
            {
                retire = 10;
            }

            // If the user’s number of siblings is 0, then they will have a vacation home in __(location),
            //or 1 then they will have a vacation home in __(location), 
            //or 2 then they will have a vacation home in ___(location), 
            //or 3 then they will have a vacation home in ___(location), 
            //or more than 3 then they will have a vacation home in ____(location). 
            //If the user enters anything other than a number greater than or equal to 0, they should get a bad vacation home!
            string vacationHome;
            if (numOfSiblings == 0 )
            {
                vacationHome = "Chicago";
            } 
            else if (numOfSiblings == 1)
            {
                vacationHome = "Atlanta";
            }
            else if (numOfSiblings == 2)
            {
               vacationHome=  "Cleveland";
            }
            else if (numOfSiblings == 3)
            {
                vacationHome = "Orlando";
            }    
            else if ( numOfSiblings > 3)
            {
                vacationHome = "Brazil";
            }
            else
            {
                vacationHome = "nowhere";
            }

            // Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation (i.e.car, boat, plane, etc.)

            string vehicle;
            switch (favColor)
            {
                case "red": 
                case "orange":
                case "yellow":
                    vehicle = "car";
                    break;

                case "green":
                    vehicle = "boat";
                    break;

                case "blue": 
                case "indigo": 
                    vehicle = "plane";
                    break;

                case "purple":
                case "violet":
                    vehicle = "limo";
                    break;

                default:
                    vehicle = "bicycle";
                    break;
            }



            // If the user’s birth month is 1-4, they will have $____ in the bank;
            //if the user's birth month is 5-8, they will have $____ in the bank; 
            //and if it is 9-12, then they will have $____ in the bank. 
            //If the user enters something other than 01-12 as their birth month, they will have $0.00 in the bank.

            string money;
            switch (month)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    money = "$10,000";
                    break;
                   
                case "5":
                case "6":
                case "7":
                case "8":
                    money = "$20,000";
                    break;

                case "9":
                case "10":
                case "11":
                case "12":
                    money =  "$5,000";
                    break;

                default:
                    money = "$0";
                    break;
            }


            //Part 3
            // The user’s fortune should be written as such:
            // [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
            // Program should be able to handle whether or not a user inputs capital or lowercase letters.

            Console.WriteLine((firstName) + " " + (lastName) + " will retire in " + (retire) + " years with " + (money) + " in the bank,");
            Console.WriteLine("a vacation home in " + (vacationHome) + " and travel by " + (vehicle) + "." );

        }
    }
}
