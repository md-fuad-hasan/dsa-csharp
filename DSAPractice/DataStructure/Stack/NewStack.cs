using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.DataStructure.Stack
{
    public class NewStack
    {
        public NewStack()
        {
            MyStack st = new MyStack();

            st.Push(6);
            st.Push(7);
            st.Push(8);

            st.Display();
            Console.WriteLine($"The size of stack is : {st.Count()}");

            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Top());
            st.Display();
            Console.WriteLine(st.Pop());
            Console.WriteLine($"The size of stack is : {st.Count()}");

            Console.WriteLine(st.Pop());

            st.Display();
        }
    }
}
