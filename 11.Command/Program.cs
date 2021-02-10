using _11.Command.Commands;
using _11.Command.Devices;
using System;

namespace _11.Command
{
    class Program
    {
        /// <summary>
        /// 命名模式：将请求封装为对象，发出请求的对象和执行请求的对象解耦，两者通过命令对象耦合。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Light light = new Light();
            TV tv = new TV();
            CeilingFan fan = new CeilingFan();

            RemoteCtrlPad pad = new RemoteCtrlPad();
            pad.RegisterCommand(nameof(Light), light);
            pad.RegisterCommand(nameof(TV), tv);
            pad.RegisterCommand(nameof(CeilingFan), fan);
            pad.RegisterCommand(nameof(CeilingFan.SetHigh), new CeilingFanHighCmd(fan), new DeviceOffCmd(fan));
            pad.RegisterCommand(nameof(CeilingFan.SetMedium), new CeilingFanMediumCmd(fan), new DeviceOffCmd(fan));
            pad.RegisterCommand(nameof(CeilingFan.SetLow), new CeilingFanLowCmd(fan), new DeviceOffCmd(fan));

            pad.OnButtonClicked();
            pad.OffButtonClicked();

            Console.ReadKey();
        }
    }
}
