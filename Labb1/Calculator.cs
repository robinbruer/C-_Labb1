using System;
namespace Labb1
{
    public class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double NumberInMemory { get; set; }

        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = 0; 
            
        }

        public override string ToString()
        {
            return $"First number: { FirstNumber } Second number: { SecondNumber } Number in memory: { NumberInMemory }";
        }

        public double SumNumbers () => FirstNumber + SecondNumber;
        
        public double MultiplyNumbers () => FirstNumber * SecondNumber;

        public double SumInBetween ()
        {
            double sum = 0;

            for (double i = FirstNumber; i <= SecondNumber; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}