using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class RemoteControl
    {
        Command[] onCommands = new Command[7];
        Command[] offCommands = new Command[7];
        Command undoCommand;
        Stack<Command> commandHistory = new Stack<Command>();
        public RemoteControl()
        {
            Command noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
            undoCommand = noCommand;
        }

        public void UndoButtonWasPushed()
        {
            if (commandHistory.Count > 0)
            {
                Command commandToUndo = commandHistory.Pop();
                commandToUndo.Undo();
            }
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            commandHistory.Push(onCommands[slot]);
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            commandHistory.Push(offCommands[slot]);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n----- Remote Control ----- \n");
            for(int i = 0;i < onCommands.Length;i++)
            {
                sb.Append("[slot " + i + "] "+ onCommands[i] + " \t\t  " + offCommands[i] + "\n");
            }
            return sb.ToString();
        }
    }
}
