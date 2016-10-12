using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyLittleTrees
{
    interface ITree
    {
        void GrowTrunk();
        void GrowBranches();
        void NewBranch();
        void Ouch(int n);
        string Description();
    }
}
