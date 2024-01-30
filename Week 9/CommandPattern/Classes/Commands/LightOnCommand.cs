using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class LightOnCommand : Command
    {
        Light light;
        bool prevStatus;

        public LightOnCommand(Light light)
        {
            this.light = light;
            prevStatus = light.IsOn; 
        }

        public void Execute()
        {
            prevStatus = light.IsOn;  
            light.On();
        }
        public void Undo()
        {
            if (prevStatus)
            {
                light.On();
            }
            else
            {
                light.Off();
            }
        }
    }
}
