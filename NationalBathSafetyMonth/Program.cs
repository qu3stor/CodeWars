using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalBathSafetyMonth
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine(Bath("VqlVOkCguPtxaof", "|~~~~|"));
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        public static bool Bath(string s, string x)
        {
            // Happy Coding
            if (s.Length <= x.Length - 2)
            {
                return false;
            }
            else
                return true;

        }
    }
}
