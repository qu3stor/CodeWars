using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeadAnts
{
    class Program
    {
        static void Main(string[] args)
        {
            string ants = null; // --> 10
            //string ants = "t.naat.a..tn.an...att.n.n.an..anttan..n.n.tant.a.t.at"; // --> 9
            //string ants = "a.an.atat.at.a..aannt.t.nn.tn.n..ntt....tt..nn.t.aana"; //-->11
            //string ants = "ant anantt aantnt"; 
            Console.WriteLine(DeadAntCount(ants));
            

            Console.ReadKey();
        }

        public static int DeadAntCount(string ants)
        {
            if (ants==null)
            {
                return 0;
            }
            else
            {
                Console.WriteLine(ants);
                int antsAlive = Regex.Matches(ants, "ant").Count;
                int countA = ants.Count(x => x == 'a');
                int countN = ants.Count(x => x == 'n');
                int countT = ants.Count(x => x == 't');
                int max = Math.Max(countA, Math.Max(countN, countT));
                int deadAnts = max - antsAlive;

                return deadAnts;

            }
        }
    }
}
