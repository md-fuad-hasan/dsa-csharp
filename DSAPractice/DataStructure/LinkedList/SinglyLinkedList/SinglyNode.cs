using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.DataStructure.LinkedList.SinglyLinkedList
{
    internal class SinglyNode
    {
        public int value;
        public SinglyNode? next;

        public SinglyNode(int value)
        {
            this.value = value;
            next = null;
        }
    }
}
