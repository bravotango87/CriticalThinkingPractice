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
        public int AddTwonumbers(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            return result;
        }

        
        // create new method in class. pass in values.
        public void RunCalculations()
        {
            int result1 = AddTwonumbers(8, 40);
            int result2 = AddTwonumbers(200, 50);
            int result = AddTwonumbers(result1, result2);
            Console.WriteLine("The sum is " + result);
            
            
        }
    }
}
  