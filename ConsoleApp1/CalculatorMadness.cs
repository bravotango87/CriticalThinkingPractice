using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingExercise
{
    class CalculatorMadness
    {


        public CalculatorMadness()
        {
            GetSum();
        }
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            return result;
        }

        
        // create new method in class. pass in values.
        public void RunCalculations()
        {
            int sum1 = AddTwoNumbers(8, 40);
            int sum2 = AddTwoNumbers(200, 50);
            int result = AddTwoNumbers(sum1, sum2);
            Console.WriteLine("The sum is " + result);
            
            
        }

        // create method to subtract 

        public int SubtractTwoNumbers(int numberOne, int numberTwo)
        {
            int sum = numberOne - numberTwo;
            return sum;
        }

        // create method to multiply two numbers.

        public int MultiplyTwoNumbers(int numberOne, int NumberTwo)
        {
            int sum = numberOne * NumberTwo;
            return sum;
        }

        // create method to divide two numbers.

        public int DivideTwoNumbers(int numberOne, int numberTwo)
        {
            int sum = numberOne / numberTwo;
            return sum;
        }

        public void GetSum()
        {
            int sum1 = AddTwoNumbers(6, 5);
            int sum2 = MultiplyTwoNumbers(40, 35);
            int sum3 = DivideTwoNumbers(sum2, 4);
            int sum4 = SubtractTwoNumbers(sum1, sum3);
            int sum5 = MultiplyTwoNumbers(2, 2);
            int sumTotal = AddTwoNumbers(sum4, sum5);

            Console.WriteLine(sumTotal);
        }
    }

}
  