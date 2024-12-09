using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.SinglyLinkedList
{
    public class NewSinglyLinkedList
    {

        
        public NewSinglyLinkedList()
        {
            SinglyLinkedList sl = new SinglyLinkedList();

            sl.Insert(5);
            sl.Insert(6);
            sl.Insert(7);
            sl.Insert(4);
            sl.Insert(8);
            sl.Insert(2);

            sl.Remove();
            sl.Remove();

            Console.Write($"The list is : ");
            sl.Display();
            Console.WriteLine();

            Console.WriteLine($"The length of list is {sl.Count()}");

            if (sl.Find(3))
            {
                Console.WriteLine("The number is found.");
            }
            else
            {
                Console.WriteLine("The number is not found.");
            }
        }


    }
}
