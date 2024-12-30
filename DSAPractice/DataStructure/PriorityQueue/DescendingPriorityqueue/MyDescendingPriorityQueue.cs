using DSAPractice.DataStructure.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.DataStructure.PriorityQueue.DescendingPriorityqueue
{
    public class MyDescendingPriorityQueue
    {


        public QueueNode? front;
        public MyDescendingPriorityQueue()
        {
            front = null;
        }

        public void Enqueue(int val)
        {
            QueueNode queueNode = new QueueNode(val);

            if (front == null)
            {
                front = queueNode;

                return;
            }
            if (front.value < val)
            {
                queueNode.next = front;
                front = queueNode;
                return;
            }
            QueueNode? current = front;
            while (current.next != null)
            {
                if (current.next.value < val)
                {
                    queueNode.next = current.next;
                    current.next = queueNode;
                    return;
                }
                current = current.next;
            }

            current.next = queueNode;

        }

        public int? Dequeue()
        {
            if (front == null)
            {
                return null;
            }
            QueueNode current = front;
            front = front.next;
            return current.value;
        }

        public int? Front()
        {
            if (front == null)
            {
                return null;
            }

            return front.value;
        }

        public int Count()
        {
            int cnt = 0;
            QueueNode? current = front;
            while (current != null)
            {
                cnt++;
                current = current.next;
            }

            return cnt;
        }


        public void Display()
        {
            QueueNode? current = front;
            if (current == null)
            {
                Console.WriteLine("The Queue is empty.");
                return;
            }
            while (current != null)
            {
                Console.Write(current.value + " ");

                current = current.next;
            }

            Console.WriteLine();
        }
    }
}

