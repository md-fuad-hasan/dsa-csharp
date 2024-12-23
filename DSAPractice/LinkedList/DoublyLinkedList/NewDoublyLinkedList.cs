using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.LinkedList.DoublyLinkedList
{
    public class NewDoublyLinkedList
    {
        public NewDoublyLinkedList()
        {
            MyDoublyLinkedList dls = new MyDoublyLinkedList();
            dls.Insert(5);
            dls.Insert(3);
            dls.Insert(6);

            Console.WriteLine(dls.Count());
            dls.Display();
            dls.DisplayReverse();

            dls.Remove();

            dls.Display();
            dls.DisplayReverse();

            dls.Remove();

            dls.Display();
            dls.DisplayReverse();

            dls.Remove();

            dls.Display();
            dls.DisplayReverse();
            Console.WriteLine(dls.Count());

            dls.Remove();
            dls.Remove();

            dls.Display();
            dls.DisplayReverse();

            dls.InsertAt(2, 5);

            dls.Display();
            dls.DisplayReverse();

            dls.InsertAt(0, 7);

            dls.Display();
            dls.DisplayReverse();

            dls.InsertAt(0, 3);

            dls.Display();
            dls.DisplayReverse();

            dls.InsertAt(1, 9);

            dls.Display();
            dls.DisplayReverse();

            dls.InsertAt(3, 2);

            dls.Display();
            dls.DisplayReverse();

            dls.InsertAt(0, 4);

            dls.Display();
            dls.DisplayReverse();

            dls.InsertAt(5, 8);

            dls.Display();
            dls.DisplayReverse();

        }
    }
}
