using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class Light
    {
        private string location;

        public bool IsOn { get; internal set; }

        public Light(string location) 
        {
            this.location = location;
        }
        public void On()
        {
            Console.WriteLine("Light is turned on");
        }

        public void Off()
        {
            Console.WriteLine("Light is turned off");

        }
    }
}
