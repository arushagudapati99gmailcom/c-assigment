using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Swap
    {
        public static void swap(ref int a, ref int b)
        {
            a = a * b;
            b = a / b;
            a = a / b;
        }
        public static void Main(string[] args)
        {
            int a = 10, b = 15;
            Console.WriteLine($"before Swap a={a} b ={b}");
            swap(ref a, ref b);

            Console.WriteLine($"after Swap a= {a} b={b}");
        }
    }
}
