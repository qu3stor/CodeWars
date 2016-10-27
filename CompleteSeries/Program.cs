using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteSeries
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] test1 = { 2, 1, 2 };
            CompleteSeries(test1);

            Console.WriteLine(CompleteSeries(test1));
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }


        public static int[] CompleteSeries(int[] arr)
        {
            bool unique = arr.Distinct().Count() == arr.Length;

            if( unique == false)
            {
                return new int[] { 0 };
            }
            else
            {
                Array.Sort(arr);
                List<int> list = new List<int>();
                list.AddRange(Enumerable.Range(0, arr[arr.Length - 1] + 1));
                int[] arr1 = list.ToArray();
                return arr1;
            }
            

            
        }
    }
}
