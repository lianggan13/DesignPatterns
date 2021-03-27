namespace _15.Visitor.Interfaces
{
    public interface IRadio
    {
        void Receive();
        void Stop();
        void TurnOn();
        void TurnOff();
        void ModulateDirection(bool forward);
    }
}
