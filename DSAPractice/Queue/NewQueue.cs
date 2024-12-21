using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Queue
{
    public class NewQueue
    {
        public NewQueue()
        {
            MyQueue q = new MyQueue();
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            q.Enqueue(8);

            q.Display();

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            q.Display();

            Console.WriteLine(q.Front());
            Console.WriteLine(q.Front());
            Console.WriteLine(q.Front());

            q.Display();

            q.Dequeue();
            q.Dequeue();
            q.Dequeue();

            if (q.Count() > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
            else
            {
                Console.WriteLine("The Queue is already empty.");
            }

            q.Display();

        }
    }
}
