using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingExercise
{
    class CPU
    {
        // member variables (Has a)

        public string Manufacturer;
        public string Name;

        // constructor (Spawner)

        public CPU (string manufacturer, string name)
        {
            this.Manufacturer = manufacturer;
            this.Name = name;
        }
        

        // member methods (Can do)

        

        public void CheckRequirements(Applications applications, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            if (ram.totalGigabytes >= applications.requiredRAM && hardDrive.availableStorage >= applications.requiredStorage)
            {
                hardDrive.ProcessInstall(applications, hardDrive, ram, gpu);
            }
            else
            {
                Console.WriteLine("Does not meet requirements to run");
            }
        }
    }
}
