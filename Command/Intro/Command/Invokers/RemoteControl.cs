using Command.Commands;
using Command.Commands.Abstractions;
using System.Text;

namespace Command.Invokers
{
    // Remote Control is the Invoker
    public  class RemoteControl
    {
        #region Fields
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;
        // Number of commands that our remote controller can support
        private readonly int numberOfCommands = 10;
        #endregion

        #region Constructors
        public RemoteControl()
        {
            _onCommands = new ICommand[numberOfCommands];
            _offCommands = new ICommand[numberOfCommands];

            ICommand noCommand = new NoCommand();
            
            for (int i = 0; i < numberOfCommands; i++)
            {
                // starting with no command at all
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }
        #endregion

        #region Methods
        
        // Takes a slot position and an On and Off command to be stored in that slot
        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot]  = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
        }

        // for testing purposes
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("\n------ Remote Control -------\n");

            for (int i = 0; i < _onCommands.Length; i++)
            {
                sb.Append("[slot " + i + "] " + _onCommands[i].GetType().Name + "    " + _offCommands[i].GetType().Name + "\n");
            }

            return sb.ToString();
        }
        #endregion
    }
}
