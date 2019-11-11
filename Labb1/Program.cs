using System;

namespace Labb1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var calculator = new Calculator();
            while (true)
            {
                Console.WriteLine("1.Add two numbers\n" +
                    "2.Multiply two numbers\n" +
                    "3.Sum the numbers between two numbers.\n" +
                    "4.Add number to memory\n" +
                    "5.Clear memory\n" +
                    "6.Print calculator contents.\n" +
                    "7.Quit");

                int readInput = int.Parse(Console.ReadLine());

                switch (readInput)
                {
                    case 1:
                        SetNumbers();
                        Console.WriteLine($"Result: { calculator.SumNumbers() } \n");
                        break;
                    case 2:
                        SetNumbers();
                        Console.WriteLine($"Result: { calculator.MultiplyNumbers() } \n");
                        break;
                    case 3:
                        SetNumbers();
                        Console.WriteLine($"Result: { calculator.SumInBetween() } \n");
                        break;
                    case 4:
                        Console.WriteLine("Add number to memory ");
                        calculator.NumberInMemory = double.Parse(Console.ReadLine());
                        Console.WriteLine("Number successfully added to memory\n");
                        break;
                    case 5:
                        calculator = new Calculator();
                        Console.WriteLine("Number in memory cleared\n");
                        break;
                    case 6:
                        Console.WriteLine(calculator + "\n");
                        break;
                    case 7:
                        Console.WriteLine("Goodbye");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            void SetNumbers()
            {
                Console.WriteLine("Insert first number to add: ");
                calculator.FirstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Insert second number to add: ");
                calculator.SecondNumber = double.Parse(Console.ReadLine());
            }
        }

        
    }
}
