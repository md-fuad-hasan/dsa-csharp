using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Algorithm.Sorting.InsertionSort
{
    public class MyInsertionSort
    {
        IList<int> ls;
        public MyInsertionSort()
        {
            ls = new List<int>();
        }

        public void Add(int i)
        {
            ls.Add(i);
        }

        // Pick the smallest then swap
        public IList<int> InsertionSort()
        {
            for (int i = 1;i< ls.Count ; i++)
            {
                int temp = ls[i];
                int j = i - 1;

                while (j >= 0 && ls[j] > temp)
                {
                    ls[j+1] = ls[j];

                    j--;
                }


                ls[j+1] = temp;
            }

            return ls;
        }
    }
}
