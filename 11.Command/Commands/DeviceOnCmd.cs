using _11.Command.Devices;
namespace _11.Command.Commands
{
    public class DeviceOnCmd : ICommand
    {
        private readonly IDevice device;
        public DeviceOnCmd(IDevice dev)
        {
            this.device = dev;
        }

        public virtual void Execute()
        {
            device.On();
        }

        public virtual void Undo()
        {
            device.Off();
        }
    }
}
