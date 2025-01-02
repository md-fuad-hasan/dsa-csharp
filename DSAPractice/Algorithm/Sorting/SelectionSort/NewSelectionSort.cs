using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Algorithm.Sorting.SelectionSort
{
    public class NewSelectionSort
    {
       
        public NewSelectionSort()
        {

            MySelectionSort ls = new MySelectionSort();

            ls.Add(5);
            ls.Add(2);
            ls.Add(7);
            ls.Add(9);
            ls.Add(4);
            ls.Add(5);

            IList<int> list = ls.SelectionSort();

            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }


    }
}
