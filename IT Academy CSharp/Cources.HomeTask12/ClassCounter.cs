using System;

namespace Cources.HomeTask12
{
    class ClassCounter
    {
        public delegate void MethodContainer();

        public event MethodContainer onEnumeration;
        public void Count()
        {
            for (int i = 0; i < 3000; i++)
            {
                if (i == 250)
                {
                    onEnumeration();                    
                }
            }
        }
    }
}

