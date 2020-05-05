using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingExercise
{
    class Motherboard
    {
        // member methods (Has a)


        public string manufacturer;
        public RAM temporaryMemory;
        public CPU processor;
        public HardDrive storage;
        public GPU graphics;
        
       // constructor (Spawner)

        public Motherboard(string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            this.manufacturer = manufacturer;
            this.temporaryMemory = ram;
            this.processor = cpu;
            this.storage = hardDrive;
            this.graphics = gpu;
        }

        // member methods (Can do)
        

        public void ProcessInstall(Applications applications) // have this method call from the CPU
        {

        }


       
    }
}
