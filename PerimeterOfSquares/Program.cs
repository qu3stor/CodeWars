using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibo(7));
            Console.ReadKey();
        }


        public static long Fibo(long n)
        {
            List<long> fiboNumbers = new List<long>();
            long a = 1;
            long b = 1;
            fiboNumbers.Add(a*4);
            fiboNumbers.Add(b*4);

            for (int i = 3; i <= n + 1; i++)
            {
                long c = a + b;
                a = b;
                b = c;
                fiboNumbers.Add(c*4);
            }

            long total = 0;
            foreach (long number in fiboNumbers)
            {
                total += number;
            }

            return total;
        }
        
    }
}
