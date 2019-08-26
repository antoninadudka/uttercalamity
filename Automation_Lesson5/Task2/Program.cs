using System;

namespace Task2
{
    class Car
    {
        string Name { get; set; }

        public CarParts[] carModelParts = new CarParts[3];

        public Car(string carName)        
        {
            Name = carName;

            switch (Name)
            {
                case "Lada":
                    carModelParts[0] = new CarParts("Bucket");
                    carModelParts[1] = new CarParts("Nuts");
                    carModelParts[2] = new CarParts("Cement");
                    break;
                case "BMW":
                    carModelParts[0] = new CarParts("Bicycle");
                    carModelParts[1] = new CarParts("Blades");
                    carModelParts[2] = new CarParts("Sakura");
                    break;
                case "Ford":
                    carModelParts[0] = new CarParts("Bucket");
                    carModelParts[1] = new CarParts("Nuts");
                    carModelParts[2] = new CarParts("Bicycle");
                    break;
                case "Audi":
                    carModelParts[0] = new CarParts("Rings");
                    carModelParts[1] = new CarParts("Nuts");
                    carModelParts[2] = new CarParts("Cement");
                    break;
                case "Nissan":
                    carModelParts[0] = new CarParts("Sakura");
                    carModelParts[1] = new CarParts("Blades");
                    carModelParts[2] = new CarParts("Cement");
                    break;
            }
        }
    }

    class CarParts
    {
        string PartName { get; }
        public double PartCost { get; set; }

        public CarParts(string carPartName)
        {
            PartName = carPartName;
            
            switch (PartName)
            {
                case "Bucket":
                    PartCost = 0.5;
                    break;
                case "Nuts":
                    PartCost = 0.3;
                    break;
                case "Cement":
                    PartCost = 2.6;
                    break;
                case "Bicycle":
                    PartCost = 5.0;
                    break;
                case "Rings":
                    PartCost = 3.99;
                    break;
                case "Blades":
                    PartCost = 11.3;
                    break;
                case "Sakura":
                    PartCost = 7.08;
                    break;
            }
        }
    }

    class Calculator
    {
        public static double Calculate(Car car)
        {
            double result = 0;
            double partCost = 0;

            foreach (CarParts currentPart in car.carModelParts)
            {
                partCost = currentPart.PartCost;
                result = result + partCost;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one model: Lada / BMW / Ford / Audi / Nissan");
            Car requestedModel = new Car(Console.ReadLine());

            try
            {
                Console.WriteLine("Total price: {0}", Calculator.Calculate(requestedModel));
            }
            catch
            {
                Console.WriteLine("Model unknown.");
            }

            Console.ReadKey();
        }
    }
}
