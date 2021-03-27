using _15.Visitor.Interfaces;

namespace _15.Visitor.Adapters
{
    class RadioMediaAdapter : IMedia
    {
        private IRadio radio = null;
        public RadioMediaAdapter(IRadio radio)
        {
            this.radio = radio;
        }
        public void Backward()
        {
            radio.ModulateDirection(false);
        }

        public void Close()
        {
            radio.TurnOff();
        }

        public void Forward()
        {
            radio.ModulateDirection(true);
        }

        public void Open()
        {
            radio.TurnOn();
        }

        public void Pause()
        {
            radio.Stop();
        }

        public void Play()
        {
            radio.Receive();
        }

        public void Stop()
        {
            radio.Stop();
        }


    }
}
