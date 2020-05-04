using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingExercise
{
    class Computer
    {

        // member variables (Has a)

        RAM ram;
        CPU cpu;
        GPU gpu;
        HardDrive hardDrive;
        Motherboard motherboard;


        // constructor (Spawner)
        public Computer()
        {
            ram = new RAM("short term memory");
            cpu = new CPU("Apple", "MacBook");
            gpu = new GPU("Intel", 32);
            hardDrive = new HardDrive(1200, 800);
            motherboard = new Motherboard("china made", cpu, ram, hardDrive, gpu);
        }





        // member methods (Can do)


        public void BuildComputer()
        {

        }

    }

}
    

