using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingExercise
{
    public abstract class Applications
    {
        // member variables (Has a)


        public string ApplicationName;
        public string ApplicationType;
        public double RequiredRAM;
        public double RequiredStorage;

        // constructor (Spawner)


        public Applications()
        {
            ApplicationName = AppName();
            ApplicationType = AppType();
            RequiredRAM = GetRequiredRAM(); // in gigabytes
            RequiredStorage = GetRequiredStorage(); // in gigabytes
        }

        // member methods (Can do)

        public string AppName()
        {
            Console.WriteLine("What is the name of this app ?");
            return Console.ReadLine();
        }

        public string AppType()
        {
            Console.WriteLine("What kind of app is this ?");
            return Console.ReadLine();
                
        }
       
        public double GetRequiredRAM()
        {
            Console.WriteLine("How much RAM is required to run this app ?");
            return double.Parse(Console.ReadLine());
        }

        public double GetRequiredStorage()
        {
            Console.WriteLine("What is the required storage for this app ?");
            return double.Parse(Console.ReadLine());
        }

        
    }
}
