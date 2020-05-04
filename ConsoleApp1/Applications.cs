using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingExercise
{
    class Applications
    {
        public string ApplicationName;
        public string ApplicationType;
        public double RequiredRAM;
        public double RequiredStorage;

        public Applications()
        {
            ApplicationName = "Slack";
            ApplicationType = "Messaging Service";
            RequiredRAM = 4.0; // in gigabytes
            RequiredStorage = 0.512; // in gigabytes
        }
    }
}
