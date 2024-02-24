using Command.Commands.Abstractions;
using Command.Receivers;

namespace Command.Commands
{
    public class HottubOffCommand : ICommand
    {
        private readonly Hottub _hottub;

        public HottubOffCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public void Execute()
        {
            _hottub.Cool();
            _hottub.Off();
        }
    }
}
