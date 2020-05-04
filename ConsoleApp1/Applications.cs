using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingExercise
{
    public abstract class Applications
    {
        // member variables (Has a)


        public string applicationName;
        public string applicationType;
        public double requiredRAM;
        public double requiredStorage;

        // constructor (Spawner)


        public Applications()
        {
            applicationName = "Slack";
            applicationType = "Messaging service";
            requiredRAM = 4.0; // in gigabytes
            requiredStorage = 0.512; // in gigabytes
        }

        // member methods (Can do)

        
    }
}
