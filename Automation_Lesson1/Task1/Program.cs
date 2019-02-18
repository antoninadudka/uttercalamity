using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string xInput = "";
            string yInput = "";
            string zInput = "";

            double x = 0;
            double y = 0;
            double z = 0;

            Console.WriteLine("Input number x: ");
            xInput = Console.ReadLine();
            while (!double.TryParse(xInput, out x))
            {
                Console.WriteLine("Invalid input. Input valid number x: ");
                xInput = Console.ReadLine();
            }

            Console.WriteLine("Input number y: ");
            yInput = Console.ReadLine();
            while (!double.TryParse(yInput, out y))
            {
                Console.WriteLine("Invalid input. Input valid number y: ");
                yInput = Console.ReadLine();
            }

            Console.WriteLine("Input number z: ");
            zInput = Console.ReadLine();
            while (!double.TryParse(zInput, out z))
            {
                Console.WriteLine("Invalid input. Input valid number z: ");
                zInput = Console.ReadLine();
            }

            double result1 = (x + y) * (Math.Pow(z, 2) + 1);
            double result2 = (x % z - 1) * Math.Sqrt(y);
            double result3 = (x * y + y * z) / Math.Pow(z, 2);

            Console.WriteLine("x = {0}; y = {1}; z = {2}", x, y, z);
            Console.WriteLine("First expression result: " + result1);
            Console.WriteLine("Second expression result: " + result2);
            Console.WriteLine("Third expression result: " + result3);
            Console.ReadKey();
        }
    }
}
