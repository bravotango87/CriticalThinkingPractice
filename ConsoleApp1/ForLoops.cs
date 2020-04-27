using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingExercise
{
    class ForLoops
    {
        // 1.  Write a for loop that will run 5 times

        public void DisplayForLoop(string I)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Modify the loop to print out every incrementation of the for-loop’s counter.

        public void PrintIncrement()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        // 3. Using the same loop, change it to now print backwards from 9.

        public void PrintBack()
        {
           for (int i = 9; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 4a. Write a loop that will run as many times as a user wants (32). Have run forward

        public void RunLoop()
        {
            for (int i = 0; i < 33; i++)
            {
                Console.WriteLine(i);
            }
        }

        // 4b. Take in user input and use the value to run the for loop.

        public void UserLoop() 
        {

            int userInput;
            Console.WriteLine("Pick a number");
            userInput = Convert.ToInt32(Console.ReadLine());
            for (int i= 0; i < userInput; i++)
            {
                Console.WriteLine(i);
                
            }
        }

        // 5a. Declare a string above the for loop with a value of “Hello World”.
        // 5b. Yooop should run 11 times for each letter in the string.
        public void ModifyLoop() // string word = "hello world"
        {
            string greeting = "Hello World";
            for (int i = greeting.Length; i < greeting.Length; i++)
            {
                if (i != greeting.Length)
                {
                    continue;
                }
                Console.WriteLine(greeting);
               
            }

        // 6. Print out every letter of Hello World one at a time.
        }

        public void PrintLetter(string word) // string word = "hello world"
        {
            for(int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
                
                Console.ReadLine();
            }
            
        }
        


}
}

