using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging_excercises
{
    class NullPointerExceptionChallenge
    {
        public static void Q2()
        {
            string str = null;
            //edited
            int length;
            if(str == null) { length = 0; }
            else {  length = str.Length; }
            //
            Console.WriteLine("Length of the string is: " + length);
            Console.ReadLine(); // To prevent console from closing
        }
    }
}
