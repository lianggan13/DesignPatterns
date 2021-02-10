using _11.Command.Devices;

namespace _11.Command.Commands
{
    public class CeilingFanLowCmd : ICommand
    {
        private CeilingFan fan;

        public CeilingFanLowCmd(CeilingFan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.SetLow();
        }

        public void Undo()
        {
            fan.Off();
        }
    }


}
