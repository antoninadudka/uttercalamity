using System;

namespace Task1
{
    class Rectangle
    {
        private readonly double side1, side2;

        public Rectangle (double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            double result = side1 * side2;
            return result;
        }

        public double PerimeterCalculator()
        {
            double result = (side1 + side2) * 2;
            return result;
        }
    }

    class Validation
    {
        public static double GetValidInput(string paramName)
        {
            Console.WriteLine("Input {0}:", paramName);

            double resultInput;
            string userInput = Console.ReadLine();

            while (!double.TryParse(userInput, out resultInput) || resultInput <= 0)
            {
                Console.WriteLine("Invalid input. Input {0}:", paramName);
                userInput = Console.ReadLine();
            }

            return resultInput;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double length, width;

            length = Validation.GetValidInput("length");
            width = Validation.GetValidInput("width");

            Rectangle Rectangle1 = new Rectangle(length, width);

            Console.WriteLine("Rectangle area: {0}", Rectangle1.AreaCalculator());
            Console.WriteLine("Rectangle perimeter: {0}", Rectangle1.PerimeterCalculator());

            Console.ReadKey();
        }
    }
}
