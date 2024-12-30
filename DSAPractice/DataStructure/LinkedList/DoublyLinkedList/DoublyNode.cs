using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.DataStructure.LinkedList.DoublyLinkedList
{
    public class DoublyNode
    {
        public int value;
        public DoublyNode? previous;
        public DoublyNode? next;

        public DoublyNode(int val)
        {
            value = val;
            previous = null;
            next = null;
        }
    }
}
