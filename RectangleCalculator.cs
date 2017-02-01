/* Create application that allows a user to input the height and width of a rectangle
 * and output the area and perimeter.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleCalculator
{
    class RectangleCalculator
    {
        static void Main(string[] args)
        {   // Declare variables
            double rectangleHeight,
                   rectangleWidth,
                   rectangleArea,
                   rectanglePerimeter;

            DisplayInstructions();   // Call DisplayInstructions() method to display the instructions for this application

            rectangleHeight = InputDimension("Height"); // Call InputDimension() method to get the height of a rectangle

            rectangleWidth = InputDimension("Width");   // Call InputDimension() method to get the width of a rectangle

            // Call CalculateArea() method to calculate the rectangle area
            rectangleArea = CalculateArea(rectangleHeight, rectangleWidth);  

            // Call CalculatePerimeter() method to calculate the rectangle perimeter
            rectanglePerimeter = CalculatePerimeter(rectangleHeight, rectangleWidth);

            // Call DisplayResults() method to display the results
            DisplayResults(rectangleArea, rectanglePerimeter);

            Console.ReadKey();
        }

        // Create DisplayInstructions() method
        public static void DisplayInstructions()
        {
            Console.WriteLine("This program will calculate area and perimeter of a rectangle.");
            Console.WriteLine();
            Console.WriteLine("You will be asked to enter the height and width of a rectangle.");
            Console.WriteLine();
            return;
        }

        // Create InputDimension() method
        public static double InputDimension(string side)
        {   // Declare local variables needed only by this method
            string inputValue;
            double input;

            // Prompt the user to enter input
            Console.Write("Please enter the {0}: ", side);
            inputValue = Console.ReadLine();
            input = double.Parse(inputValue);
            return input;
        }

        // Create CalculateArea() method to calculate the area of a rectangle
        public static double CalculateArea(double height, double width)
        {   // Declare local variable
            double area;

            // Calculate the area
            area = height * width;
            return area;
        }

        // Create CalculatePerimeter() method to calculate the perimeter of a rectangle
        public static double CalculatePerimeter(double height, double width)
        {   // Declare local variable
            double perimeter;

            // Calculate the perimeter
            perimeter = 2 * (height + width);
            return perimeter;
        }

        // Create DisplayResults() method to display the results in a tabular formatted
        public static void DisplayResults(double area, double perimeter)
        {
            Console.WriteLine();
            Console.WriteLine("{0,27}", "Rectangle Calculator");
            Console.WriteLine();
            Console.WriteLine("{0,-25} {1:F2}", "Area of Rectangle:", area);
            Console.WriteLine("{0,-25} {1:F2}", "Perimeter of Rectangle:", perimeter);
            return;
        }
    }
}
