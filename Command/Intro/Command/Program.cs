using Command.Commands;
using Command.Receivers;

namespace Command
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var remoteControl = new Invokers.RemoteControl();

            // Lights
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);


            // Garage Door
            GarageDoor garageDoor = new GarageDoor("");

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            // Stereo
            Stereo stereo = new Stereo("Living Room");

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            
            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);

            Console.WriteLine(remoteControl);

            // Turning on and off the living room lights
            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);

            // Turning on and off the kitchen lights
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);

            // Opening and closing the garage door
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);

            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
        }
    }
}