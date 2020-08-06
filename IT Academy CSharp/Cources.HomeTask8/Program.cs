using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;

namespace Cources.HomeTask8
{
    public class Program
    {


        public static void Main(string[] arg)
        {
            var charConteyner = new char[16] {'Y', 'c', 'h', 'e', 'b', 'n', 'o', 'e', '_', 'z', 'a', 'd', 'a', 'n', 'i', 'e'};


            var ind = charConteyner.CharIndexOf('z') ;
            var result = charConteyner.CharContains('c');


            Console.WriteLine(ind);
            Console.WriteLine(result);
            Console.ReadLine();



        }
    }
}
