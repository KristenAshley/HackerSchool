using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationAbroad
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {

            Console.Write("What is your name?  ");
            Console.Write("Hello, {0}!  ", Console.ReadLine());

            string UserChoice, UserTemperature, UserDistance, UserWeight, userHeight;
            Program uc = new Program();
            do
            {
                UserChoice = uc.getChoice();
                switch (UserChoice)
                {
                    case "1":
                        Console.WriteLine("You chose {0}", UserChoice);
                        UserTemperature = uc.getTemperature();
                        break;
                    case "2":
                        Console.WriteLine("You chose {0}", UserChoice);
                        UserDistance = uc.getDistance();
                        break;
                    case "3":
                        Console.WriteLine("You chose {0}", UserChoice);
                        UserWeight = uc.getWeight();
                        break;
                    case "4":
                        Console.WriteLine("You chose {0}", UserChoice);
                        userHeight = uc.getHeight();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection.  Please Try Again");
                        break;
                }
                // Pause to allow the user to see the results
                Console.WriteLine();
                Console.Write("press Enter key to continue...");
                Console.ReadLine();
                Console.WriteLine();

            } while (UserChoice != "Q" && UserChoice != "q"); // Keep going until the user wants to quit 
        }
        string getChoice()
        {
            string UserChoice;
            // Print A Menu
            Console.Write("Welcome to Conversations Abroad!\nSelect the measurement which you would like to convert:\n...Or Select Q to Quit\n");
            Console.WriteLine("1 for Temperature");
            Console.WriteLine("2 for Distance");
            Console.WriteLine("3 for Weight");
            Console.WriteLine("4 for Height");
            // Retrieve the user's choice
            UserChoice = Console.ReadLine();
            Console.WriteLine();
            return UserChoice;
        }

        string getTemperature()
        {
            string UserTemperature;
            int InputFahrenheit = 0;
            var retry = true;
            while (retry)
            {
                Console.Write("\nEnter Degrees Fahrenheit\t");
                string userInput = Console.ReadLine();
                bool result = int.TryParse(userInput, out InputFahrenheit);
                if (result == false)
                {
                    Console.WriteLine("Please Enter a Whole Number.");
                }
                else
                {
                    retry = false;
                    Fahrenheit fahr = new Fahrenheit(InputFahrenheit);
                    Console.Write("{0} Fahrenheit", fahr.Degrees);
                    Celsius c = (Celsius)fahr;
                    Console.Write(" = {0} Celsius", c.Degrees);
                    // Retrieve the user's choice
                    UserTemperature = Console.ReadLine();
                    return UserTemperature;
                }
            }
            return null;
        }

        string getDistance()
        {
            string UserDistance;
            uint InputMiles;
            var retry = true;
            while (retry)
            {
                Console.WriteLine("\nEnter Amount of Miles\t");
                string userInput = Console.ReadLine();
                bool result = uint.TryParse(userInput, out InputMiles);
                if (result == false)
                {
                    Console.WriteLine("Please Enter a Whole Number.");
                }
                else
                {
                    retry = false;
                    double kilometers1 = ConvertDistance.ConvertMilesToKilometers(InputMiles);
                    Console.WriteLine("{0} Miles = {1} Kilometers", InputMiles, kilometers1);
                    UserDistance = Console.ReadLine();
                    return UserDistance;
                }
            }
            return null;
        }

        string getWeight()
        {
            string UserWeight;
            uint InputPounds;
            var retry = true;
            while (retry)
            {
                Console.WriteLine("\nEnter Amount of Pounds\t");
                string userInput = Console.ReadLine();
                bool result = uint.TryParse(userInput, out InputPounds);
                if (result == false)
                {
                    Console.WriteLine("Please Enter a Whole Number.");
                }
                else
                {
                    retry = false;
                    double kilograms = InputPounds / 2.204627;
                    Console.WriteLine("{0} Pounds = {1} kilograms", InputPounds, kilograms);
                    UserWeight = Console.ReadLine();
                    return UserWeight;
                }
            }
            return null;
        }

        string getHeight()
        {
            string UserHeight;
            uint InputInches, InputFeet;
            var retry = true;
            while (retry)
            {
                Console.WriteLine("\nEnter Amount of Feet\t");
                string userInputFeet = Console.ReadLine();
                Console.WriteLine("\nEnter Amount of Inches\t");
                string userInputInches = Console.ReadLine();
                bool resultFeet = uint.TryParse(userInputFeet, out InputFeet);
                bool resultInches = uint.TryParse(userInputInches, out InputInches);
                if (((resultFeet && resultInches) == false) || InputInches > 11)
                {

                    Console.WriteLine("Please enter a valid height.");
                }
                else
                {
                    retry = false;
                    double TotalMeters = ((((InputFeet * 12) + InputInches) * 2.54) / 100);
                    Console.WriteLine("{0} Feet {1} Inches = {2} Meters", InputFeet, InputInches, TotalMeters);
                    UserHeight = Console.ReadLine();
                    return UserHeight;
                }
            }
            return null;
        }
    }
}





