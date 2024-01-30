using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            // Instantieer lichten, fans, etc.
            Light livingRoomLight = new Light("Living Room");
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            // Test commando's
            remoteControl.OnButtonWasPushed(0);   // Zet licht aan
            remoteControl.OffButtonWasPushed(0);  // Zet licht uit
            remoteControl.UndoButtonWasPushed();  // Undo laatste commando (zet licht weer aan)
        }
    }
}