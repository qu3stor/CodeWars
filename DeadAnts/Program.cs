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
            //..anat.aa.a.t.tantnt.anntn.tn.an.t......at.n..atnt.an --> 10
            //t.naat.a..tn.an...att.n.n.an..anttan..n.n.tant.a.t.at --> 9
            //string ants = "a.an.atat.at.a..aannt.t.nn.tn.n..ntt....tt..nn.t.aana"; //-->11
            string ants = "ant anantt aantnt"; 
            int antsAlive = Regex.Matches(ants, "ant").Count;

            Console.ReadKey();
        }
    }
}
