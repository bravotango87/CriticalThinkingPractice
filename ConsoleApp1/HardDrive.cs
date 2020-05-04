using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingExercise
{
    class HardDrive
    {
        // member variables (Has a)

        public double TotalStorage;
        public double AvailableStorage;
        public List<Applications> ApplicationsInHardDrive;


       // constructor (Spawner)
        public HardDrive(double totalStorage, double availableStorage)
        {
            TotalStorage = totalStorage;
            AvailableStorage = availableStorage;
            ApplicationsInHardDrive = new List<Applications>();
           
        }

        // member methods (Can do)

       

    }


}   


