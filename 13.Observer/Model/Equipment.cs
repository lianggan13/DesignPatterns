namespace _13.Observer.Model
{
    public enum EQPState { Offline = 0, Online };
    public class Equipment
    {
        private StateNotifier notifier;
        private EQPState state;
        public Equipment(StateNotifier notifier)
        {
            this.notifier = notifier;
        }

        public EQPState State
        {
            get => state;
            set
            {
                if (state != value)
                {
                    state = value;
                    notifier.ChangeState(this);
                }
            }
        }
    }
}
