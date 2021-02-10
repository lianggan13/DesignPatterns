using _13.Observer.Interfaces;
using System;

namespace _13.Observer.Model
{
    public class ManufactureLarge : IStateChangeable
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
                    Console.WriteLine(nameof(ManufactureLarge) + ": " + nameof(EQPState.Offline));
                    break;
                case EQPState.Online:
                    Console.WriteLine(nameof(ManufactureLarge) + ": " + nameof(EQPState.Online));
                    break;
            }
        }
    }
}
