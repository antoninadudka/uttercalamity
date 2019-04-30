using System;

namespace Calculator
{
    class Validation
    {
        public static double GetValidInput(string paramName)
        {
            Console.WriteLine("Input {0}:", paramName);

            double resultInput;
            string userInput = Console.ReadLine();

            while (!double.TryParse(userInput, out resultInput))
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
            double x, y;
            
            x = Validation.GetValidInput("x");
            y = Validation.GetValidInput("y");

            Console.WriteLine("Choose operation: +-/*^");
            char operation  = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            switch (operation)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                    break;
                case '*':
                    Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                    break;
                case '/':
                    Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
                    break;
                case '^':
                    Console.WriteLine("{0} ^ {1} = {2}", x, y, Math.Pow(x, y));
                    break;
                default:
                    Console.WriteLine("There is no such operation");
                    break;
            }

            Console.ReadKey();
        }
    }
}
