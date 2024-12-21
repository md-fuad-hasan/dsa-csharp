using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Queue
{
    public class MyQueue
    {
        private QueueNode? front;
        public MyQueue() 
        {
            front = null;
        }

        public void Enqueue(int val)
        {
            if(front == null)
            {
                front = new QueueNode(val);
                return;
            }

            QueueNode current = front;

            while(current.next != null)
            {

                current = current.next;
            }

            current.next = new QueueNode(val);
        }

        public int? Dequeue()
        {
            if(front == null)
            {
                return null;
            }

            QueueNode? current = front;
            front = current.next;

            return current.value;
        }

        public int? Front()
        {
            if(front == null)
            {
                return null;
            }

            return front.value;
        }

        public int Count()
        {
            int cnt = 0;
            QueueNode? current = front;
            while(current != null)
            {
                cnt++;
                current = current.next;
            }

            return cnt;
        }

        public void Display()
        {
            QueueNode? current = front;
            if(current == null)
            {
                Console.WriteLine("The Queue is empty.");
            }

            while (current != null)
            {
                Console.Write(current.value+ " ");
                current = current.next;
            }

            Console.WriteLine();
        }
    }
}
