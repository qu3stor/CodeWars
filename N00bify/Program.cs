using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace N00bify
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "After conversions, this should be!";
            Console.WriteLine(N00bify(input));
            Console.WriteLine(N00bify("Well, 32 chars without OMG on!"));
            Console.WriteLine(N00bify("Never try cheating a Kata, friend."));
            Console.ReadKey();

        }

        public static string N00bify(string text)
        {
            string[] charsToreplace = { "too", "to", "fore", "for", "oo", "be", "are", "you", "please", "people", "have", "know", "really", "s", ",", ".", "'" };
            string[] charsReplaced = { "2", "2", "4", "4", "00", "b", "r", "u", "plz", "ppl", "haz", "no", "rly", "z" , "", "", "" };
            string[] splitted = text.Split(' ');

            int counter = 0;

            while (counter < charsReplaced.Length)
            {
                text = ReplaceString(text, charsToreplace[counter], charsReplaced[counter], StringComparison.CurrentCultureIgnoreCase);
                counter++;
            }

            
            //length = text.Replace("?", "").Length;

            if (text.First() == 'h' || text.First() == 'H')
            {
                text = text.ToUpper();
            }
            

            if (text.First() == 'w' || text.First() == 'W')
            {
                text = text.Insert(0, "LOL ");
            }

            int length = text.Replace("!", "").Length;

            if (length >= 32)
            {
                
                if (text.Contains("LOL"))
                {
                    text = text.Insert(4, "OMG ");
                }
                else text = text.Insert(0, "OMG ");
            }

            
            string[] split = text.Split(' ');
            int numberOfWords = split.Length;

            for (int i = 1; i < split.Length; i+=2)
            {
                split[i] = split[i].ToUpper();
            }

            text = String.Join(" ", split);
            //text = text.Replace(" i ", " I ");
            text = text.Replace("?", String.Concat(Enumerable.Repeat("?", numberOfWords)));
            text = text.Replace("!", String.Concat(Enumerable.Repeat("!1", numberOfWords/2)));

            if (text.Contains("!"))
            {
                if (numberOfWords % 2 !=0)
                {
                    text = text + "!";
                }

            }

            return text;
        }

        public static string ReplaceString(string str, string oldValue, string newValue, StringComparison comparison)
        {
            StringBuilder sb = new StringBuilder();

            int previousIndex = 0;
            int index = str.IndexOf(oldValue, comparison);
            while (index != -1)
            {
                sb.Append(str.Substring(previousIndex, index - previousIndex));
                sb.Append(newValue);
                index += oldValue.Length;

                previousIndex = index;
                index = str.IndexOf(oldValue, index, comparison);
            }
            sb.Append(str.Substring(previousIndex));

            return sb.ToString();
        }

    }
}
