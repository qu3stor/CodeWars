using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            int step = 1;
            //int arrLen = max % step == 0 ? max / step : max / step + 1;
            int arrLen = (max - min) / step + 1;
            int[] result = new int[arrLen];
            result[0] = min;

            for (int i = 1; i < arrLen; i++)
            {
                result[i] = result[i-1] +  step;
            }

            

            Console.ReadKey();
        }
    }
}
