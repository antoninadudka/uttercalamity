using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string xInput, yInput;
            double x, y;
            
            Console.WriteLine("Input x:");
            xInput = Console.ReadLine();
            while (!double.TryParse(xInput, out x))
            {
                Console.WriteLine("Invalid input. Input x:");
                xInput = Console.ReadLine();
            }

            Console.WriteLine("Input y:");
            yInput = Console.ReadLine();
            while (!double.TryParse(yInput, out y))
            {
                Console.WriteLine("Invalid input. Input y:");
                yInput = Console.ReadLine();
            }

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
