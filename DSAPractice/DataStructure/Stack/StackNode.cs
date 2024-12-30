using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.DataStructure.Stack
{
    public class StackNode
    {
        public int value;
        public StackNode? previous;

        public StackNode(int val)
        {
            value = val;
            previous = null;
        }
    }
}
