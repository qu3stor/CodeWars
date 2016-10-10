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
            dec2FactString(371993326789901217);
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
            for (int i = list.Count() - 1; i >= 0 ; i--)
            {
                output += dictionary[(int)list[i]];
            }


            //for (int i = 1; i <= 36; i++)
            //{
            //    next = first / i;
            //    list.Add((first % i).ToString());
            //    first = next;
            //    if (first / i == 0)
            //        break;
            //}
            return "abc";
        }

    }
}
