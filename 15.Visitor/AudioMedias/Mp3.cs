using _15.Visitor.Interfaces;
using System;

namespace _15.Visitor.AudioMedias
{
    public class Mp3 : IAudioMedia
    {
        public void Backward()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Mp3), nameof(Backward), string.Empty);
            Console.WriteLine(s);
        }

        public void Close()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Mp3), nameof(Close), string.Empty);
            Console.WriteLine(s);
        }

        public void Forward()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Mp3), nameof(Forward), string.Empty);
            Console.WriteLine(s);
        }

        public void Mute(int num)
        {
            string s = string.Format("{0}.{1}({2})", nameof(Mp3), nameof(Mute), num);
            Console.WriteLine(s);
        }

        public void Open()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Mp3), nameof(Open), string.Empty);
            Console.WriteLine(s);
        }

        public void Pause()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Mp3), nameof(Pause), string.Empty);
            Console.WriteLine(s);
        }

        public void Play()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Mp3), nameof(Play), string.Empty);
            Console.WriteLine(s);
        }

        public void Stop()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Mp3), nameof(Stop), string.Empty);
            Console.WriteLine(s);
        }

        public void Tune(int num)
        {
            string s = string.Format("{0}.{1}({2})", nameof(Mp3), nameof(Tune), num);
            Console.WriteLine(s);
        }
    }
}
