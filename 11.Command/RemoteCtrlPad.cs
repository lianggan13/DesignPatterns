using _11.Command.Commands;
using _11.Command.Devices;
using System.Collections.Generic;

namespace _11.Command
{
    public class RemoteCtrlPad
    {
        private Dictionary<string, ICommand> onCmds;
        private Dictionary<string, ICommand> offCmds;
        public RemoteCtrlPad()
        {
            onCmds = new Dictionary<string, ICommand>();
            offCmds = new Dictionary<string, ICommand>();
        }
        public void RegisterCommand(string name, IDevice device)
        {
            onCmds[name] = new DeviceOnCmd(device);
            offCmds[name] = new DeviceOffCmd(device);
        }

        public void RegisterCommand(string name, ICommand onCmd, ICommand offCmd)
        {
            onCmds[name] = onCmd;
            offCmds[name] = offCmd;
        }

        public void OnButtonClicked()
        {
            foreach (var v in onCmds)
            {
                v.Value.Execute();
            }
        }
        public void OffButtonClicked()
        {
            foreach (var v in offCmds)
            {
                v.Value.Execute();
            }
        }

        public void OnButtonClicked(string name)
        {
            onCmds[name].Execute();
        }
        public void OffButtonClicked(string name)
        {
            offCmds[name].Execute();
        }
    }
}
