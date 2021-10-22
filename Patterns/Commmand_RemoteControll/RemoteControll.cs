using System;
using System.Collections.Generic;

namespace Commmand_RemoteControll
{
    public class RemoteControll
    {
        private ICommand[] onCommands;
        private ICommand[] offCommands;
        private List<ICommand> _lastCommands;

        public RemoteControll()
        {
            onCommands = new ICommand[5];
            offCommands = new ICommand[5];
            _lastCommands = new List<ICommand>();
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot-1] = onCommand;
            offCommands[slot-1] = offCommand;
        }

        public void onButtonPushed(int slot)
        {
            if (onCommands.Length < slot && slot <= 0)
                throw new ArgumentException("Incorrect slot");
            
            onCommands[slot-1].Execute();
            _lastCommands.Add(onCommands[slot-1]);
        }

        public void offButtonPushed(int slot)
        {
            if (onCommands.Length < slot && slot <= 0)
                throw new ArgumentException("Incorrect slot");
            
            offCommands[slot-1].Execute();
            _lastCommands.Add(offCommands[slot-1]);
        }

        public void undoButtonPushed()
        {
            if(_lastCommands.Count < 1)
                Console.WriteLine("No commands to undo");
            else
            {
                _lastCommands[_lastCommands.Count-1].Undo();
                _lastCommands.RemoveAt(_lastCommands.Count-1);
            }
        }
    }
}