namespace _09.Iterator.Iterators
{
    public interface IIteratorable<T>
    {
        IIterator<T> GetIterator();
    }
}
