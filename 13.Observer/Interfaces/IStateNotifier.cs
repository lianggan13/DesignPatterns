using _13.Observer.Model;

namespace _13.Observer.Interfaces
{
    public interface IStateNotifier
    {
        void ChangeState(Equipment eqp);
        void Add(IStateChangeable stateChangeable);
        bool Remove(IStateChangeable stateChangeable);
    }
}
