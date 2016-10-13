using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyLittleTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree happy = new Tree();
            happy.Ouch(-3);
            //happy.GrowBranches();
            //happy.Ouch(-3);
            //happy.Ouch(50);
            //happy.NewBranch();
            //happy.NewBranch();
            //happy.NewBranch();
            //happy.GrowBranches();
            //happy.Ouch(1);
            //happy.GrowTrunk();
            //happy.Ouch(6);


            Console.WriteLine(happy.Description());
            Console.ReadKey();
        }
    }

    public class Tree : ITree
    {
        public int trunk { get; set; }
        public string description { get; set; }
        public List<Branch> branchess = new List<Branch>();


        public Tree()
        {
            this.trunk = 1;

        }
        
        public void GrowTrunk()
        {
            trunk++;
        }

        public void GrowBranches()
        {
            foreach (Branch branch in branchess)
                branch.length++;
        }

        public void NewBranch()
        {
            branchess.Add(new Branch() { length = 1, height = trunk });
        }

        public void Ouch(int n)
        {
            if (branchess.Count < 1 || n > branchess.Count() || n < 1 )
            {
                
            }
            else
            {
                branchess.RemoveAt(n - 1);
            }
            
        }

        public string Description()
        {
            if (branchess.Count > 0)
            {
                string positions = String.Join(",", branchess.Select(p => p.height));
                string lengths = String.Join(",", branchess.Select(l => l.length));
                description = String.Format("The tree trunk is {0} unit(s) tall! There are {1} branch(es) that have position(s): {2} and length(s): {3}!", trunk, branchess.Count(), positions, lengths);
                return description;
            }
            else
            {
                description = String.Format("The tree trunk is {0} unit(s) tall! There are 0 branch(es)!", trunk);
            }
            return description;
        }
    }

    public class Branch
    {
        public int height { get; set; }
        public int length { get; set; }
        
    }


}
