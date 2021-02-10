namespace _04.Experience_Reconstruction
{
    public class FibonacciContainer : MathContainer
    {
        public FibonacciContainer() : base()
        {
        }

        public FibonacciContainer(int capacity) : base(capacity)
        {
        }

        public override long Count()
        {
            long result = 0;
            int seed = m_mathList.Count + 1;
            if (seed == 0 || seed == 1)
            {
                result = 1;
            }
            else
            {
                result = this[seed - 1] + this[seed - 2];
            }
            return result;
        }
    }
}
