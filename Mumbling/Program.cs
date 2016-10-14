using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accum("NyffsGeyylB"));
            Console.ReadKey();

        }


        // Soution from codewars
        //public static String Accum(string s)
        //{
        //    return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));

        //}


        public static String Accum(string s)
        {
            char[] array = s.ToLower().ToCharArray();
            var list = new List<string>();

            for (int i = 0; i < array.Length; i++)
            {
                list.Add(UpperFirst(new string(array[i], i + 1)));

            }
            string output = String.Join("-", list);
            return output;
        }

        public static string UpperFirst(string text)
        {
            return char.ToUpper(text[0]) + ((text.Length > 1) ? text.Substring(1).ToLower() : string.Empty);
        }


    }
}
