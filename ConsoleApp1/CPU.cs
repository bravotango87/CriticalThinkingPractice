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

        

        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            if (ram.TotalGigabytes > app.RequiredRAM && hardDrive.AvailableStorage > app.RequiredStorage)
            {
                hardDrive.ProcessInstall(app, hardDrive, ram, gpu);
            }
            else
            {
                Console.WriteLine("Does not meet requirements to run");
            }
        }
    }
}
