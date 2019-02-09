using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string widthInput = "";
            string heightInput = "";
            string lengthInput = "";

            double width = 0;
            double height = 0;
            double length = 0;

            Console.WriteLine("Input width: ");
            widthInput = Console.ReadLine();
            while (!double.TryParse(widthInput, out width))
            {
                Console.WriteLine("Invalid input. Input valid width: ");
                widthInput = Console.ReadLine();
            }

            Console.WriteLine("Input height: ");
            heightInput = Console.ReadLine();
            while (!double.TryParse(heightInput, out height))
            {
                Console.WriteLine("Invalid input. Input valid height: ");
                heightInput = Console.ReadLine();
            }

            Console.WriteLine("Input length: ");
            lengthInput = Console.ReadLine();
            while (!double.TryParse(lengthInput, out length))
            {
                Console.WriteLine("Invalid input. Input valid length: ");
                lengthInput = Console.ReadLine();
            }

            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2) + Math.Pow(length, 2));

            Console.WriteLine("width = " + width + "; height = " + height + "; length = " + length);
            Console.WriteLine("Parallelepiped diagonal length: " + diagonal);
            Console.ReadKey();
        }
    }
}
