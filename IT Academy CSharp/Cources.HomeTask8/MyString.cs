using System;
using System.Dynamic;
using System.Linq;


namespace Cources.HomeTask8
{
    public static class MyString
    {
        public static bool CharContains(this char[] charConteyner, char value)
        {
            bool result = false;

            foreach (var item in charConteyner)
            {
                if (item == value)
                {
                    result = true;
                }
            }
            Console.WriteLine("Все норм");
            return result;
        }

        public static int CharIndexOf(this char[] charConteyner, int ind ) 
        {
            
            for (int i = 0; i < charConteyner.Length; i++)
            {
                if (charConteyner[i] == ind)
                {
                    return i;
                }
            }
            return -1;
        
        }


    } 




    
}