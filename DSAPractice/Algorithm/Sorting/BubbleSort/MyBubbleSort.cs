using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Algorithm.Sorting.BubbleSort
{
    public class MyBubbleSort
    {
        IList<int> ls;
        public MyBubbleSort()
        {
            ls = new List<int>();
        }

        public void Add(int i)
        {
            ls.Add(i);
        }

        // Swap with pair element to ensure largest stay last
        // Best Case - O(n)
        public IList<int> BubbleSort()
        {
            for (int i = 0; i < ls.Count - 1; i++)
            {
                bool test = false;
                for (int j = 0 ; j < ls.Count-i-1; j++)
                {

                    if (ls[j] > ls[j+1])
                    {
                        int temp = ls[j];
                        ls[j] = ls[j+1];
                        ls[j + 1] = temp;
                        test = true;
                    }

                }

                if (!test)
                {
                    break;
                }

                
            }

            return ls;
        }
    }
}
