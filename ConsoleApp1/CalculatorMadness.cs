using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingExercise
{
    class CalculatorMadness
    {


        public CalculatorMadness()
        {
            //GetSum();
        }
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            return result;
        }

        
        // create new method in class. pass in values.
        public void RunCalculations()
        {
            int result1 = AddTwoNumbers(8, 40);
            int result2 = AddTwoNumbers(200, 50);
            int result = AddTwoNumbers(result1, result2);
            Console.WriteLine("The sum is " + result);
            
            
        }

        // create method to subtract 

        public int SubtractTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            return result;
        }

        // create method to multiply two numbers.

        public int MultiplyTwoNumbers(int numberOne, int NumberTwo)
        {
            int result = numberOne * NumberTwo;
            return result;
        }

        // create method to divide two numbers.

        public int DivideTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne / numberTwo;
            return result;
        }
    }

}
  