using _15.Visitor.Interfaces;
using _15.Visitor.Visitors;
using System;

namespace _15.Visitor.VideoMedias
{
    public class Avi : IVideoMedia
    {
        public void Accept(IVideoMediaVisitor visitor)
        {
            if (visitor is IAviMedioVisitor)
            {
                (visitor as IAviMedioVisitor).Visit(this);
            }
        }

        public void Backward()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Avi), nameof(Backward), string.Empty);
            Console.WriteLine(s);
        }

        public void Close()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Avi), nameof(Close), string.Empty);
            Console.WriteLine(s);
        }

        public void Forward()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Avi), nameof(Forward), string.Empty);
            Console.WriteLine(s);
        }

        public void Mute(int num)
        {
            string s = string.Format("{0}.{1}({2})", nameof(Avi), nameof(Mute), num);
            Console.WriteLine(s);
        }

        public void Open()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Avi), nameof(Open), string.Empty);
            Console.WriteLine(s);
        }

        public void Pause()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Avi), nameof(Pause), string.Empty);
            Console.WriteLine(s);
        }

        public void Play()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Avi), nameof(Play), string.Empty);
            Console.WriteLine(s);
        }

        public void ShowScript()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Avi), nameof(ShowScript), string.Empty);
            Console.WriteLine(s);
        }

        public void Stop()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Avi), nameof(Stop), string.Empty);
            Console.WriteLine(s);
        }

        public void Tune(int num)
        {
            string s = string.Format("{0}.{1}({2})", nameof(Avi), nameof(Tune), num);
            Console.WriteLine(s);
        }
    }
}
