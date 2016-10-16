using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {

            string test = "abc";
            DuplicateCount(test);




            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        public static int DuplicateCount(string str)
        {
            var result = str.ToLower().GroupBy(c => c).Where(c => c.Count() > 1);
            return result.Count();
        }


    }
}
