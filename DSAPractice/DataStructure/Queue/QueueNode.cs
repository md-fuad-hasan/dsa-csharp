using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.DataStructure.Queue
{
    public class QueueNode
    {
        public int value;
        public QueueNode? next;

        public QueueNode(int val)
        {
            value = val;
            next = null;
        }
    }
}
