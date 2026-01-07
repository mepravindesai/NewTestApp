using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTestApp
{
    internal class Program
    {
        public static void Main()
        {

            int i = 50;
            while (i < 55)
            {
                Console.WriteLine(i);
                i++;
            }

            i = 50;
            Console.WriteLine("do-while Loop in C#");
            Console.WriteLine("Displaying Values!");
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i > 55);

            Console.WriteLine("For Loop in C#");
            int t;

            for (t = 0; t < 10; t++)
            {
                Console.WriteLine(t);
            }

        }
    }
}