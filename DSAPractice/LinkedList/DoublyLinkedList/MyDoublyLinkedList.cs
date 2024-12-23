using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.LinkedList.DoublyLinkedList
{
    public class MyDoublyLinkedList
    {
        private DoublyNode? head;
        private DoublyNode? tail;
        public MyDoublyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void Insert(int val)
        {
            tail = new DoublyNode(val);
            if (head == null)
            {
                head = tail;
                return;
            }

            DoublyNode? current = head;

            while (current.next != null)
            {
                current = current.next;
            }

            current.next = tail;
            tail.previous = current;

        }

        public void InsertAt(int idx, int val)
        {
            if(idx< 0)
            {
                Console.WriteLine("The index is out of bounds.");
                return;
            }

            if (head == null)
            {
                if( idx == 0)
                {
                    head  =  tail = new DoublyNode(val);
                    return;
                }

                Console.WriteLine("The index is out of bounds.");

                return ;
            }

            DoublyNode newNode = new DoublyNode(val);
            DoublyNode current = head;
            if(idx == 0)
            {
                newNode.next = head;
                head.previous = newNode;

                head = newNode;

                return;
            }
            int i = 0;
            while( current.next != null )
            {
                i++;
                if (i == idx)
                {
                    newNode.previous = current;
                    newNode.next = current.next;

                    current.next.previous = newNode;
                    current.next = newNode;

                    return;
                }

                current = current.next;
            }
            i++;
            if(i == idx)
            {
                current.next = newNode;
                newNode.previous = current;

                tail = newNode;

                return;
            }

            Console.WriteLine("The index is out of bounds.");
            

        }

        public void Remove()
        {
            if(tail == null)
            {
                Console.WriteLine("The list is already Empty");
                return;
            }
            if(tail.previous == null)
            {
                head = tail = null;
                return;
            }

            tail = tail.previous;
            tail.next = null;
        }

        public void RemoveAt(int idx)
        {
            if (idx < 0)
            {
                Console.WriteLine("The index is out of bounds.");
                return;
            }
            if(head == null)
            {
                Console.WriteLine("The list is already Empty.");
                return;
            }
            DoublyNode current = head;

            if (head.next == null)
            {
                if (idx == 0)
                {
                    head = tail = null;
                    return;
                }
                Console.WriteLine("The index is out of bounds.");
                return;
            }

            int i = 0;

            if(idx == i)
            {
                head = head.next;
                head.previous = null;

                return;
            }

            while (current.next.next != null)
            {
                i++;
                if (i == idx)
                {
                    current.next.next.previous = current;
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }

            i++;
            if(i == idx)
            {
                tail = current;
                tail.next = null ;
                return;
            }

            Console.WriteLine("The index is out of bounds.");


        }

        public int Count()
        {
            int cnt = 0;

            DoublyNode current = head;

            while(current != null)
            {
                cnt++;
                current = current.next;
            }

            return cnt;
        }

        public void Display()
        {
            DoublyNode? current = head;

            if (current == null)
            {
                Console.WriteLine("The List is Empty.");
                return;
            }
            while (current != null)
            {
                Console.Write(current.value+" ");
                current = current.next;
            }
            Console.WriteLine();

        }

        public void DisplayReverse()
        {
            DoublyNode? current = tail;

            if(current == null)
            {
                Console.WriteLine("The List is Empty.");
                return;
            }
            while (current != null)
            {
                Console.Write(current.value+" ");
                current = current.previous;
            }

            Console.WriteLine();

        }
    }
}
