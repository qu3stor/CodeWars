using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungarianVowelHarmony
{
    class Program
    {
        static void Main(string[] args)
        {
            Dative("úr");
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        public static string Dative(string word)
        {
            for (int i = word.Length - 1; i >= 0; i--)
            {
                char a = word[i];

                if (a == 'a' || a == 'á' || a == 'o' || a == 'ó' || a == 'u' || a == 'ú')
                {
                    word += "nak";
                    
                    break;
                }

                else if (a == 'e' || a == 'é' || a == 'o' || a == 'i' || a == 'í' || a == 'ö' || a == 'ő' || a == 'ü' || a == 'ű')
                {
                    word += "nek";
                    
                    break;
                }
            }

            return word;                
        }
    }
}
