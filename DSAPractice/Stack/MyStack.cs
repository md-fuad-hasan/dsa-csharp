using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Stack
{
    public class MyStack
    {
        private StackNode? top;
        public MyStack()
        {
            top = null;
        }

        public void Push(int val)
        {
            if(top == null)
            {
                top = new StackNode(val);
                return;
            }

            StackNode stackNode = new StackNode(val);

            stackNode.previous = top;
            top = stackNode;

        }

        public int? Pop()
        {
            if( top == null)
            {
                Console.WriteLine("The Stack is already empty");
                return null;
            }
            StackNode current = top;

            if ( top.previous == null )
            {
                top = null;
                return current.value;
            }
            
            top = current.previous;

            return current.value;

        }

        public int? Top()
        {
            if( top == null)
            {
                Console.WriteLine("The stack is empty!");
                return null;
            }

            return top.value;
        }

        public int Count()
        {
            int cnt = 0;

            StackNode? current = top;

            while( current != null )
            {
                cnt++;
                current = current.previous;

            }

            return cnt;
        }

        public void Display()
        {
            StackNode? current = top;
            if( current == null )
            {
                Console.WriteLine("The stack is empty.");
                return;
            }

            while(current != null)
            {
                Console.Write(current.value+ " ");
                current = current.previous;
            }

            Console.WriteLine();
        }


    }
}
