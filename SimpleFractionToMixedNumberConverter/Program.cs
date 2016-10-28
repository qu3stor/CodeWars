using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFractionToMixedNumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /// Console.WriteLine(GetDelimiter(3, 7));
            //Console.WriteLine(2 / 4);
            Console.WriteLine(MixedFraction("0/-4"));
            Console.ReadKey();
        }

        public static string MixedFraction(string s)
        {
            int a = Int32.Parse(s.Split('/')[0]);
            int denominator = Int32.Parse(s.Split('/')[1]);

            if (a == 0 && denominator !=0)
            {
                return "0";
            }

            if (a % denominator == 0)
            {
                return (a / denominator).ToString();
            }

            int intPart = a / denominator;
            int numerator = Math.Abs(a % denominator);
            long gcd = GetDelimiter(numerator, Math.Abs(denominator));
            string result = String.Empty;

            if (gcd == 1)
            {
                if (intPart == 0)
                {
                    result = String.Format("{0}/{1}", numerator, Math.Abs(denominator));
                }
                else
                {
                    result = String.Format("{0} {1}/{2}", intPart, numerator, Math.Abs(denominator));
                }
            }
            else
            {
                if (intPart == 0)
                {
                    result = String.Format("{0}/{1}", numerator / gcd, Math.Abs(denominator) / gcd);
                }
                else
                {
                    result = String.Format("{0} {1}/{2}", intPart, numerator / gcd, Math.Abs(denominator) / gcd);
                }
                
            }
            return result;
        }


        public static long GetDelimiter(long a, long b)
        {

            while (a != b)
            {
                if (a > b)
                {
                    long tmp = a;
                    a = b;
                    b = tmp;
                }
                b = b - a;
            }
            return a;
        }
    }
}
