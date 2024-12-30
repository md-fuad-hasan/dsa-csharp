using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.DataStructure.PriorityQueue.AscendingPriorityQueue
{
    public class NewAscendingPriorityQueue
    {
        public NewAscendingPriorityQueue()
        {
            MyAscendingPriorityQueue apq = new MyAscendingPriorityQueue();

            apq.Enqueue(6);
            apq.Enqueue(7);
            apq.Enqueue(3);
            apq.Enqueue(9);
            apq.Enqueue(5);
            apq.Enqueue(5);
            apq.Enqueue(9);
            apq.Enqueue(3);

            apq.Display();

            apq.Dequeue();
            apq.Display();
            apq.Dequeue();
            apq.Display();

            Console.WriteLine(apq.Count());
            Console.WriteLine(apq.Front());

            apq.Display();

            apq.Dequeue();
            apq.Display();
        }
    }
}
