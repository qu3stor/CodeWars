using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "tew234his is 46846number:23 72-34";
            var b = new String(a.ToCharArray().Where(ch => Char.IsDigit(ch)).ToArray());
            long f = Int64.Parse(b);
            string c = Regex.Match(a, @"\d+").Value;
          
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(f);


            Console.ReadKey();
        }
    }
}
