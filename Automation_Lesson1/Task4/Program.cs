using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringInput1 = "";
            string stringInput2 = "";
            string symbol;

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
            symbol = Console.ReadLine();
            while ((symbol.Length > 1) || (symbol == ""))
            {
                Console.WriteLine("Input only one non-empty symbol: ");
                symbol = Console.ReadLine();
            }

            int indexOfSymbol = stringConcatenated.LastIndexOf(symbol);
            if (indexOfSymbol < 0) Console.WriteLine("{0} is not found in {1}",symbol, stringConcatenated);
            else Console.WriteLine("Index of {0} in {1}: {2}", symbol, stringConcatenated, indexOfSymbol);
            Console.ReadKey();
        }
    }
}
