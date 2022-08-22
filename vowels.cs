using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class vowels
    {
        public static bool isVowel(char y)
        {
            y = char.ToUpper(y);
            return (y == 'A' || y == 'E' || y == 'I' || y == 'O' || y == 'U');
        }

        public static int countVowels(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (isVowel(str[i]))
                {
                    ++count;
                }
            }
            return count;
        }

        public static void Main(string[] args)
        {

            string str = "arusha";

            Console.WriteLine(countVowels(str));
        }
    }
}
