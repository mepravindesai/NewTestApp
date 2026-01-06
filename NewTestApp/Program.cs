using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            Console.Write("Enter first num:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second num:");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.Write("Final Sum :");
            Console.WriteLine(sum);
            Console.WriteLine(new Refer());
            Console.ReadKey();

        }
    }
}
