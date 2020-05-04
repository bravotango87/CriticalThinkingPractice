using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingExercise
{
    class Motherboard
    {
        // member methods (Has a)


        public string Manufacturer;
        public RAM TemporaryMemory;
        public CPU Processor;
        public HardDrive Storage;
        public GPU Graphics;
        
       // constructor (Spawner)

        public Motherboard(string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturer;
            TemporaryMemory = ram;
            Processor = cpu;
            Storage = hardDrive;
            Graphics = gpu;
        }

        // member methods (Can do)
        public void InstallApplication(Applications newApp, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            hardDrive.ApplicationsInHardDrive.Add(newApp);
        }




       
    }
}
