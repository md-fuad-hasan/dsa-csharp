using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Algorithm.Sorting.SelectionSort
{
    public class MySelectionSort
    {
        IList<int> ls;
        public MySelectionSort()
        {
            ls = new List<int>();
        }

        public void Add(int i)
        {
            ls.Add(i);
        }

        public IList<int> SelectionSort() 
        {
            for(int i =0; i < ls.Count-1; i++)
            {
                int idx = i;
                for(int j = i+1; j < ls.Count; j++)
                {

                    if (ls[j] < ls[idx])
                    {
                        idx = j;

                    }

                }

                int temp = ls[i];
                    ls[i] = ls[idx];
                    ls[idx] = temp;
            }

            return ls;
        }
    }
}
