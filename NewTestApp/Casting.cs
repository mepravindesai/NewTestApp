using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTestApp
{
    internal class Casting
    {
        public void implCasting()
        {
            int a = 20;
            float b;

            Console.WriteLine("Implicit conversion:");
            b = a;
            Console.WriteLine("Value of Float var b ={0}", b);
        }
    }
}
