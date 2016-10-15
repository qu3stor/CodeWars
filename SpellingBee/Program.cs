using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingBee
{
    class Program
    {
        static void Main(string[] args)
        {

            //char[][] hive = new char[][] {
            //    "b...eebee".ToCharArray(),
            //    "e.b.be.ee".ToCharArray(),
            //    "be.be.e.e".ToCharArray(),
            //    "..bebe.ee".ToCharArray(),
            //    ".e..eebbe".ToCharArray(),
            //    ".e.eebb.e".ToCharArray(),
            //    "..ee.eebb".ToCharArray(),
            //    "eeebb...e".ToCharArray(),
            //    ".bebe.ee.".ToCharArray() };

            //char[][] hive = new char[0][];
            char[][] hive = null;

            HowManyBees(hive);

            //int sada = hive.Length;

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        public static int HowManyBees(char[][] hive)
        {

            if (hive == null || hive.Length == 0 )
                return 0;


            char[,] twoDimensional = new char[hive.Length, hive[0].Length];


            for (int i = 0; i < hive.Length; i++)
            {

                for (int j = 0; j < hive[0].Length; j++)
                {
                    twoDimensional[i, j] = hive[i][j];
                }
            }


            string original = String.Empty;

            for (int i = 0; i < hive.Length; i++)
            {
                original += "-";
                for (int j = 0; j < hive[i].Length; j++)
                {
                    original += hive[i][j];
                }
            }

            char[,] transposed = new char[hive[0].Length, hive.Length];

            for (int j = 0; j < hive[0].Length; j++)
                for (int r = 0; r < hive.Length; r++)
                    transposed[j, r] = twoDimensional[r, j];



            string transposedS = String.Empty;

            for (int i = 0; i < transposed.GetLength(0); i++)
            {
                transposedS += "-";
                for (int j = 0; j < transposed.GetLength(1); j++)
                {
                    transposedS += transposed[i, j];
                }
            }

            int count = CountStringOccurrences(original + " " + transposedS, "bee");
            count += CountStringOccurrences(original + " " + transposedS, "eeb");

            return count;
        }

        public static int CountStringOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }
    }
}
