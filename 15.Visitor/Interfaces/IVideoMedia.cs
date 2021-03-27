namespace _15.Visitor.Interfaces
{
    public interface IVideoMedia : IAudioMedia
    {
        void ShowScript();
        void Accept(IVideoMediaVisitor visitor);
    }
}
