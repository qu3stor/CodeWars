using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTheMinimum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> listNew = RemoveSmallest(list);
            
            Console.ReadKey();
        }

        public static List<int> RemoveSmallest(List<int> numbers)
        {
            // Good Luck!
            //numbers.IndexOf(numbers.Min());
            if (numbers.Count > 0)
            {
                numbers.RemoveAt(numbers.IndexOf(numbers.Min()));
            }
            
            return numbers;
        }
    }
}
