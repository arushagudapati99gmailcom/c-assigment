using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{ 
    internal class function
    {
        public static int Mult(int x,int y,int z)
        {
            int mul;
            mul = x * y * z;
            return mul;
            
            
        }
        public static void Main()
        {
            int x, y, z;
            Console.WriteLine("enter x number ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y number ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter z number ");
            z = Convert.ToInt32(Console.ReadLine());
            int res = Mult(x, y, z);
            Console.WriteLine($"product of three numbers is {res}");
        }
        

        }
    }

