using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace CriticalThinkingExercise
{
    class WhileLoops
    {
        // 1. write while loop

        public void WriteWhileLoop()
        {
            int counter = 5;
            while (counter < 25)
            {
                Console.WriteLine(counter);
                counter++;
            }

        }

        // 2. take in user input for the counter

        public void UserWhile()
        {
            int userInput;
            Console.WriteLine("Pick a number");
            userInput = Convert.ToInt32(Console.ReadLine());
            while (userInput < 25)
            {
                Console.WriteLine(userInput);
                userInput++;
            }

        }

        // 3. change loop to check if counter not equal to 42. if value not equal user should re input until number is. 

        public void FourtyTwoLoop()
        {
            int userInput;
            Console.WriteLine("Please enter a number");

            userInput = Convert.ToInt32(Console.ReadLine());
            while (userInput != 42)
            {
                Console.WriteLine("Please enter number 42");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            if (userInput == 42)
            {
                Console.WriteLine("Thank you !");
            }

        }
           
    }

}
            
           
            

             
            
        
    

