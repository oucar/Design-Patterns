using Command.Commands.Abstractions;
using Command.Receivers;

namespace Command.Commands
{
    public class HottubOnCommand : ICommand
    {
        private readonly Hottub _hottub;

        public HottubOnCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public void Execute()
        {
            _hottub.On();
            _hottub.Heat();
            _hottub.BubblesOn();
        }
    }
}
