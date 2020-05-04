using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingExercise
{
    class HardDrive
    {
        // member variables (Has a)

        public double totalStorage;
        public double availableStorage;
        public List<Applications> ApplicationsInHardDrive;


       // constructor (Spawner)
        public HardDrive(double totalStorage, double availableStorage)
        {
            this.totalStorage = totalStorage;
            this.availableStorage = availableStorage;
            ApplicationsInHardDrive = new List<Applications>();
           
        }

        // member methods (Can do)

        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            hardDrive.ApplicationsInHardDrive.Add(app);
        }



    }


}   


