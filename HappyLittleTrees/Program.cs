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
            happy.GrowTrunk();
            happy.NewBranch();
            
            happy.Ouch(1);
            happy.GrowTrunk();
            happy.NewBranch();
            happy.GrowTrunk();
            happy.NewBranch();
            happy.GrowTrunk();
            happy.NewBranch();
            happy.NewBranch();
            happy.GrowBranches();
            happy.NewBranch();
            happy.NewBranch();
            

            Console.WriteLine(happy.trunk);
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
            branchess.RemoveAt(n - 1);
        }

        public string Description()
        {
            string output;
            if (branchess.Count > 0)
            {
                string positions = String.Empty;
                foreach (Branch branch in branchess)
                {
                    positions
                }


                output = ("The tree trunk is {0} unit(s) tall!There are {1} branch(es) that have position(s): _, _, _ and length(s): _, _, _!", );
                return output;
            }
        }
    }

    public class Branch
    {
        public int height { get; set; }
        public int length { get; set; }
        
    }


}
