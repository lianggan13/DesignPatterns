namespace _09.Iterator.Iterators
{
    public interface IIterator<T>
    {
        T Current { get; }
        T First();
        T Last();
        bool MoveNext();
        void Reset();


    }
}
