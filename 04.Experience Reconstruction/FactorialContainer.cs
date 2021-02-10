namespace _04.Experience_Reconstruction
{
    public class FactorialContainer : MathContainer
    {
        public FactorialContainer() : base()
        {
        }

        public FactorialContainer(int capacity) : base(capacity)
        {
        }

        public override long Count()
        {
            long result = 1;
            int seed = m_mathList.Count + 1;
            for (int i = 0; i <= seed; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
