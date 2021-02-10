using _11.Command.Devices;

namespace _11.Command.Commands
{
    public class CeilingFanHighCmd : ICommand
    {
        private CeilingFan fan;

        public CeilingFanHighCmd(CeilingFan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.SetHigh();
        }

        public void Undo()
        {
            fan.SetMedium();
        }
    }
}
