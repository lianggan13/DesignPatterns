using _15.Visitor.Interfaces;
using System;

namespace _15.Visitor.AudioMedias
{
    public class Wav : IAudioMedia
    {
        public void Backward()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Wav), nameof(Backward), string.Empty);
            Console.WriteLine(s);
        }

        public void Close()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Wav), nameof(Close), string.Empty);
            Console.WriteLine(s);
        }

        public void Forward()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Wav), nameof(Forward), string.Empty);
            Console.WriteLine(s);
        }

        public void Mute(int num)
        {
            string s = string.Format("{0}.{1}({2})", nameof(Wav), nameof(Mute), num);
            Console.WriteLine(s);
        }

        public void Open()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Wav), nameof(Open), string.Empty);
            Console.WriteLine(s);
        }

        public void Pause()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Wav), nameof(Pause), string.Empty);
            Console.WriteLine(s);
        }

        public void Play()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Wav), nameof(Play), string.Empty);
            Console.WriteLine(s);
        }

        public void Stop()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Wav), nameof(Stop), string.Empty);
            Console.WriteLine(s);
        }

        public void Tune(int num)
        {
            string s = string.Format("{0}.{1}({2})", nameof(Wav), nameof(Tune), num);
            Console.WriteLine(s);
        }
    }
}
