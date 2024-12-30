using DSAPractice.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.DataStructure.PriorityQueue.DescendingPriorityqueue
{
    public class NewDescendingPriorityQueue
    {
        public NewDescendingPriorityQueue()
        {
            MyDescendingPriorityQueue dpq = new MyDescendingPriorityQueue();

            dpq.Enqueue(6);
            dpq.Enqueue(7);
            dpq.Enqueue(3);
            dpq.Enqueue(9);
            dpq.Enqueue(5);
            dpq.Enqueue(5);
            dpq.Enqueue(9);
            dpq.Enqueue(3);

            dpq.Display();

            dpq.Dequeue();
            dpq.Display();
            dpq.Dequeue();
            dpq.Display();

            Console.WriteLine(dpq.Count());
            Console.WriteLine(dpq.Front());

            dpq.Display();

            dpq.Dequeue();
            dpq.Display();
        }
    }
}
