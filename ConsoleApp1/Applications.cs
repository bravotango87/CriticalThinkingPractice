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
            ApplicationName = "Slack";
            ApplicationType = "Messaging Service";
            RequiredRAM = 4.0; // in gigabytes
            RequiredStorage = 0.512; // in gigabytes
        }

        // member methods (Can do)

        
    }
}
