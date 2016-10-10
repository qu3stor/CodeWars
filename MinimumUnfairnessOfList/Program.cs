using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumUnfairnessOfList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinUnfairness(new int[]  { 30, 100, 1000, 150, 60, 250, 10, 120, 20 }, 0));
            Console.ReadKey();
        }

        public static int MinUnfairness(int[] arr, int k)
        {
            if (arr.Length != 0 && k != 0)
            {
                Array.Sort(arr);
                int minDelta = Int32.MaxValue;
               // int iteration = 0;

                for (int i = 0; i <= arr.Length - k; i++)
                {
                    int delta = arr[i + k - 1] - arr[i];
                    if (delta < minDelta)
                    {
                        minDelta = delta;
                        //iteration = i;
                    }

                }
                return minDelta;
            }
            else
                return 0;
        }
    }
}
