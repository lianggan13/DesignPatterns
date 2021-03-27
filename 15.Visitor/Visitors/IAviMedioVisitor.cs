using _15.Visitor.Interfaces;
using _15.Visitor.VideoMedias;

namespace _15.Visitor.Visitors
{
    public interface IAviMedioVisitor : IVideoMediaVisitor
    {
        void Visit(Avi avi);
    }
}
