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

        public CPU()
        {
            Manufacturer = "dell";
            Name = "n/a";

        }

        // member methods (Can do)

        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram)
        {

        }

        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram)
        {
            if (ram.TotalGigabytes > app.RequiredRAM && hardDrive.AvailableStorage > app.RequiredStorage)
            {
                hardDrive.InstallApplication
            }
        }
    }
}
