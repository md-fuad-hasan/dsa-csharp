using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.DataStructure.LinkedList.SinglyLinkedList
{
    public class MySinglyLinkedList
    {
        private SinglyNode? head;


        public MySinglyLinkedList()
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

        public void InsertAt(int index, int value)
        {
            if (index < 0)
            {
                Console.WriteLine("The index is out of bounds.");

                return;
            }

            if (head == null)
            {
                if (index == 0)
                {
                    head = new SinglyNode(value);
                    return;
                }

                Console.WriteLine("The index is out of bounds.");

                return;
            }
            if (index == 0)
            {
                SinglyNode node = new SinglyNode(value);
                node.next = head;
                head = node;
                return;
            }

            SinglyNode current = head;

            int i = 0;
            while (current.next != null)
            {
                i++;
                if (i == index)
                {
                    SinglyNode node = new SinglyNode(value);
                    node.next = current.next;
                    current.next = node;
                    return;

                }
                current = current.next;
            }
            i++;
            if (i == index)
            {
                SinglyNode node = new SinglyNode(value);
                current.next = node;
                return;
            }

            Console.WriteLine("The index is out of bounds.");

        }

        public void Remove()
        {
            SinglyNode current = head;
            if (current == null)
            {
                Console.WriteLine("The list is already empty.");
                return;
            }
            if (current.next == null)
            {
                head = null;
                return;
            }

            while (current.next.next != null)
            {
                current = current.next;
            }

            current.next = null;

        }

        public void RemoveAt(int index)
        {
            if (index < 0)
            {
                Console.WriteLine("The index is out of bounds.");
                return;
            }
            SinglyNode current = head;
            if (current == null)
            {
                Console.WriteLine("The list is already empty.");
                return;
            }
            if (current.next == null)
            {
                if (index == 0)
                {
                    head = null;
                    return;
                }
                Console.WriteLine("The index is out of bounds.");
                return;

            }

            if (index == 0)
            {
                head = head.next;
                return;
            }

            int i = 0;
            while (current.next.next != null)
            {
                i++;
                if (i == index)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
            i++;
            if (i == index)
            {
                current.next = current.next.next;
                return;
            }

            Console.WriteLine("The index is out of bounds.");
        }

        public int Count()
        {
            int count = 0;
            SinglyNode current = head;
            while (current != null)
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
                if (current.value == val)
                {
                    return true;
                }
                current = current.next;
            }

            return false;
        }

        public void Clear()
        {
            head = null;
        }

        public void Display()
        {
            if (head == null)
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
