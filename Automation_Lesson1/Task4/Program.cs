using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringInput1 = "";
            string stringInput2 = "";
            char symbol;

            Console.WriteLine("Input first part of the string: ");
            stringInput1 = Console.ReadLine();
            while (stringInput1 == "")
            {
                Console.WriteLine("Input non-empty first part of the string:");
                stringInput1 = Console.ReadLine();
            }

            Console.WriteLine("Input second part of the string: ");
            stringInput2 = Console.ReadLine();
            while (stringInput2 == "")
            {
                Console.WriteLine("Input non-empty second part of the string:");
                stringInput2 = Console.ReadLine();
            }

            string stringConcatenated = stringInput1 + stringInput2;

            Console.WriteLine("Input symbol: ");
            symbol = Console.ReadKey().KeyChar;
            while (Char.IsControl(symbol))
            {
                Console.WriteLine("\nInput non-empty symbol: ");
                symbol = Console.ReadKey().KeyChar;
            }

            int indexOfSymbol = stringConcatenated.LastIndexOf(symbol);
            if (indexOfSymbol < 0) Console.WriteLine("\n{0} is not found in {1}", symbol, stringConcatenated);
            else Console.WriteLine("\nIndex of {0} in {1}: {2}", symbol, stringConcatenated, indexOfSymbol);
            Console.ReadKey();
        }
    }
}
