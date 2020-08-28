using System;

namespace Cources.HomeTask12
{
    class ClassCounter
    {
        public delegate void MethodContainer();

        public event MethodContainer onCount;
        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {
                    if (onCount != null)
                    {
                        onCount();
                    }
                }
            }
        }
    }
}

