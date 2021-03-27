using _15.Visitor.VideoMedias;
using System;

namespace _15.Visitor.Visitors
{
    public class ResizeVisitor : IAviMedioVisitor, IMpegMediaVisitor
    {
        public void Visit(Avi avi)
        {
            string s = string.Format("{0}.{1}({2})", nameof(ResizeVisitor), nameof(Visit), nameof(Avi));
            Console.WriteLine(s);
        }

        public void Visit(Mpeg mpeg)
        {
            string s = string.Format("{0}.{1}({2})", nameof(ResizeVisitor), nameof(Visit), nameof(Mpeg));
            Console.WriteLine(s);
        }
    }
}
