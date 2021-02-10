using _11.Command.Devices;

namespace _11.Command.Commands
{
    public class CeilingFanMediumCmd : ICommand
    {
        private CeilingFan fan;

        public CeilingFanMediumCmd(CeilingFan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.SetMedium();
        }

        public void Undo()
        {
            fan.SetLow();
        }
    }
}
