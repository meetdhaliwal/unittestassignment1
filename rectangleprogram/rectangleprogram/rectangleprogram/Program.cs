using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleprogram_1
{

    class Program
    {
        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                Console.WriteLine("1: Get Rectangle Length");
                Console.WriteLine("2: Change Rectangle Length");
                Console.WriteLine("3: Get Rectangle Width");
                Console.WriteLine("4: Change Rectangle Width");
                Console.WriteLine("5: Get Rectangle Perimeter");
                Console.WriteLine("6: Get Rectangle Area");
                Console.WriteLine("7: Exit\n");

                Console.WriteLine("please select an option, by entering a number:/n");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                   userInput != "2" &&
                   userInput != "3" &&
                   userInput != "4" &&
                   userInput != "5" &&
                   userInput != "6" &&
                   userInput != "7")
                {
                    Console.WriteLine("This is not a valid menu option, please try again:\n");
                }
                else
                {
                    validMenuSelect = true;

                }

            }
            Console.WriteLine();
            return int.Parse(userInput);

        }
        public static int ValidateUserInput(string rectside)

        {
            int number = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($" please enter the {rectside} of the rectangle:");

                string userInput = Console.ReadLine();
               Console.WriteLine();

                bool result = int.TryParse(userInput, out number);
                if (result == false)
                {
                    Console.WriteLine("That is not a valid input, please try again:\n");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Number cannot be less than zero, please try again:\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"The {rectside} of your rectangle is now:{number}\n");
                }
            }
            return number;
        }

        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            // r.SetWidth(ValidateUserInput("width"));
            // r.SetLength(ValidateUserInput("length"));

            int l = ValidateUserInput("length");  
            int w = ValidateUserInput("width");  

           // Rectangle r = new Rectangle(l,w);     //

            int a = ValidateMenuSelection();
            Console.WriteLine(a);
            Console.ReadLine();
            switch(a)
            {
                case 1:
                    Console.WriteLine("length of the rectangle is " + r.GetLength() + ".");
                    break;
                case 2:
                    Console.WriteLine("new length of the rectangle is " + r.SetLength(ValidateUserInput("length")) + ".");
                    break;
                case 3:
                    Console.WriteLine("width of the rectangle is " + r.GetWidth() + ".");
                    break;
                case 4:
                    Console.WriteLine("new width of the rectangle is " + r.SetWidth(ValidateUserInput("width")) + ".");
                    break;
                case 5:
                    Console.WriteLine("Rectangle periometer is " + r.GetPerimeter() + ".");
                    break;
                case 6:
                    Console.WriteLine("Area of the rectangle is " + r.GetArea() + ".");
                    break;
                case 7:
                    Environment.Exit(0);
                    break;

            }

        }

    }
}
