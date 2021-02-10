using _13.Observer.Interfaces;
using System;

namespace _13.Observer.Model
{
    public class ManufactureMiddle : IStateChangeable
    {
        public void RegisterStateNotifier(IStateNotifier notifier)
        {
            notifier.Add(this);
        }

        public void DoChangeEQPState(Equipment eqp)
        {
            switch (eqp.State)
            {
                case EQPState.Offline:
                    Console.WriteLine(nameof(ManufactureMiddle) + ": " + nameof(EQPState.Offline));
                    break;
                case EQPState.Online:
                    Console.WriteLine(nameof(ManufactureMiddle) + ": " + nameof(EQPState.Online));
                    break;
            }
        }
    }
}
