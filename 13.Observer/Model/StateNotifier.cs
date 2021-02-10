using _13.Observer.Interfaces;
using System.Collections.Generic;

namespace _13.Observer.Model
{
    public class StateNotifier : IStateNotifier
    {
        private List<IStateChangeable> observers = new List<IStateChangeable>();
        public void Add(IStateChangeable stateChangeable)
        {
            observers.Add(stateChangeable);
        }

        public bool Remove(IStateChangeable stateChangeable)
        {
            return observers.Remove(stateChangeable);
        }

        public void ChangeState(Equipment eqp)
        {
            foreach (var observer in observers)
            {
                observer.DoChangeEQPState(eqp);
            }

        }
    }
}
