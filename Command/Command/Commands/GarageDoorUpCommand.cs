using Command.Commands.Abstractions;
using Command.Receivers;

namespace Command.Commands
{
    public class GarageDoorUpCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute() => _garageDoor.Up();
    }
}
