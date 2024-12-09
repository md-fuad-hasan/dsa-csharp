using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.SinglyLinkedList
{
    public class SinglyLinkedList
    {
        private SinglyNode? head;


        public SinglyLinkedList()
        {
            head = null;
        }

        public void Insert(int value)
        {
            if (head == null)
            {
                head = new SinglyNode(value);

                return;
            }

            SinglyNode current = head;

            while (current.next != null)
            {
                current = current.next;
            }
            SinglyNode node = new SinglyNode(value);

            current.next = node;
        }

        public void Remove()
        {
            SinglyNode current = head;
            if(current == null)
            {
                Console.WriteLine("The list is already empty.");
                return;
            }
            if(current.next == null)
            {
                head = null;
                return;
            }

            while(current.next.next != null)
            {
                current = current.next;
            }
            Console.WriteLine($"Removed {current.next.value}");
            current.next = null;

        }

        public int Count()
        {
            int count = 0;
            SinglyNode current = head;
            while(current != null)
            {
                count++;
                current = current.next;
            }

            return count;

        }

        public bool Find(int val)
        {
            SinglyNode current = head;
            while (current != null)
            {
                if(current.value == val)
                {
                    return true;
                }
                current = current.next;
            }

            return false;
        }

        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            SinglyNode current = head;
            while (current != null)
            {
                Console.Write($"{current.value} ");
                current = current.next;
            }
        }

       

    }
}
