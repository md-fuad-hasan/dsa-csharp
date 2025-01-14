using DSAPractice.Algorithm.Sorting.SelectionSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Algorithm.Sorting.BubbleSort
{
    public class NewBubbleSort
    {
        public NewBubbleSort()
        {

            MyBubbleSort ls = new MyBubbleSort();

            ls.Add(5);
            ls.Add(2);
            ls.Add(7);
            ls.Add(9);
            ls.Add(4);
            ls.Add(5);

            IList<int> list = ls.BubbleSort();

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
