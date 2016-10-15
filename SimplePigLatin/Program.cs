using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PigIt("Pig latin is cool"));
            
            Console.ReadKey();
        }

        public static string PigIt(string str)
        {

            string[] array = str.Split(' ');
            var pigged = array.Select(word => (word + word.First()).Substring(1)+"ay");
            string output = String.Join(" ", pigged);


            return output;

        }
    }
}
