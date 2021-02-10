using System.Collections.Generic;

namespace _04.Experience_Reconstruction
{
    public abstract class MathContainer
    {
        private const int DEFAULT_CAPACITY = 10;
        private int m_capacity;

        public int Capacity
        {
            get { return m_capacity; }
            set
            {
                if (value <= 0)
                {
                    value = DEFAULT_CAPACITY;
                }
                m_capacity = value;
            }
        }

        protected IList<long> m_mathList;

        public MathContainer()
        {
            m_mathList = new List<long>();
        }
        public MathContainer(int capacity) : this()
        {
            Capacity = capacity;
        }

        public long this[int index]
        {
            get
            {
                return m_mathList[index];
            }
            set
            {
                m_mathList[index] = value;
            }
        }

        public void Add()
        {
            m_mathList.Add(Count());
        }
        public void RemoveAt(int index)
        {
            m_mathList.RemoveAt(index);
        }

        public abstract long Count();
    }
}
