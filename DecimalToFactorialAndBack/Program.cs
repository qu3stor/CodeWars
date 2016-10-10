using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToFactorialAndBack
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(dec2FactString(371993326789901217));
            Console.WriteLine(factString2Dec("311E55B5544150121110"));
            Console.ReadKey();
        }

        public static string dec2FactString(long nb)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {
                {0,"0"},
                {1,"1"},
                {2,"2"},
                {3,"3"},
                {4,"4"},
                {5,"5"},
                {6,"6"},
                {7,"7"},
                {8,"8"},
                {9,"9"},
                {10,"A"},
                {11,"B"},
                {12,"C"},
                {13,"D"},
                {14,"E"},
                {15,"F"},
                {16,"G"},
                {17,"H"},
                {18,"I"},
                {19,"J"},
                {20,"K"},
                {21,"L"},
                {22,"M"},
                {23,"N"},
                {24,"O"},
                {25,"P"},
                {26,"Q"},
                {27,"R"},
                {28,"S"},
                {29,"T"},
                {30,"U"},
                {31,"V"},
                {32,"W"},
                {33,"X"},
                {34,"Y"},
                {35,"Z"}
            };


            long first = nb;
            long next = 0;
            List<long> list = new List<long>();
            list.Add(0);
            int counter = 1;

            while (first / counter != 0)
            {
                next = first / counter;
                first = next;
                counter++;
                list.Add((first % counter));

            }

            string output = null;
            for (int i = list.Count() - 1; i >= 0; i--)
            {
                output += dictionary[(int)list[i]];
            }


            return output;
        }


        public static long factString2Dec(string str)
        {
            Dictionary<string, long> lettersLong = new Dictionary<string, long>()
            {
                { "0", 0},
                { "1", 1},
                { "2", 2},
                { "3", 3},
                { "4", 4},
                { "5", 5},
                { "6", 6},
                { "7", 7},
                { "8", 8},
                { "9", 9},
                { "A", 10},
                { "B", 11},
                { "C", 12},
                { "D", 13},
                { "E", 14},
                { "F", 15},
                { "G", 16},
                { "H", 17},
                { "I", 18},
                { "J", 19},
                { "K", 20},
                { "L", 21},
                { "M", 22},
                { "N", 23},
                { "O", 24},
                { "P", 25},
                { "Q", 26},
                { "R", 27},
                { "S", 28},
                { "T", 29},
                { "U", 30},
                { "V", 31},
                { "W", 32},
                { "X", 33},
                { "Y", 34},
                { "Z", 35},
              };

            var dec = str.Select(letter => lettersLong[letter.ToString()]);
            var list = dec.ToList();
            long output = 0;

            for (int i = 0; i < list.Count-1; i++)
            {
                output += list[i] * Factorial(list.Count()-1-i);
            }


           
            return output;
        }

        public static long Factorial (long number)
            
        {
            if (number <= 1)
                return 1;
            return number * Factorial(number - 1);
        }

    }
}
