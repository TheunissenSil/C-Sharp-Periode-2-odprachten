﻿using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class StereoOnWithDvdCommand : Command
    {
        Stereo stereo;
        public StereoOnWithDvdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}
