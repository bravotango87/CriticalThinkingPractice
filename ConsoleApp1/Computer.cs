using System;
using System.Collections.Generic;
using System.Text;

namespace CriticalThinkingExercise
{
    class Computer
    {

        // member variables (Has a)

        public GPU graphics;
        public RAM temporaryMemory;
        public CPU processor;
        public HardDrive storage;
        public Motherboard motherboard;
        public Applications applications;
        public Games games;
        public string manufacturer;
        


        // constructor (Spawner)
        public Computer()
        {
            graphics = new GPU("AMD", 16);
            temporaryMemory = new RAM(32, "Kingston");
            processor = new CPU()
        }





        // member methods (Can do)


        public void BuildComputer()
        {

        }

    }

}
    

