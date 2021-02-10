using _11.Command.Devices;

namespace _11.Command.Commands
{
    public class DeviceOffCmd : ICommand
    {
        private readonly IDevice device;
        public DeviceOffCmd(IDevice dev)
        {
            this.device = dev;
        }

        public virtual void Execute()
        {
            device.Off();
        }

        public virtual void Undo()
        {
            device.On();
        }
    }
}
