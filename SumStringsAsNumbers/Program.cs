using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace SumStringsAsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumStrings("", "81055900096023504197206408605"));
            Console.ReadKey();

        }

        public static string sumStrings(string a, string b)
        {
            BigInteger first = new BigInteger();
            BigInteger second = new BigInteger();

            if (a != String.Empty && b != String.Empty)
            {
                first = BigInteger.Parse(a);
                second = BigInteger.Parse(b);
            }

            else if (a == String.Empty)
            {
                second = BigInteger.Parse(b);
            }
            else if (b == String.Empty)
            {
                first = BigInteger.Parse(a);
            }

            return (first + second).ToString();
        }
    }
}
