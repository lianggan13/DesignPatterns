using _13.Observer.Model;

namespace _13.Observer.Interfaces
{
    public interface IStateChangeable
    {
        void DoChangeEQPState(Equipment eqp);
        void RegisterStateNotifier(IStateNotifier notifier);
    }
}