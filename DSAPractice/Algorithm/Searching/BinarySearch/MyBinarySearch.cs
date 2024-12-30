using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Algorithm.Searching.BinarySearch
{
    public class MyBinarySearch
    {
        private readonly IList<int> ls;
        public MyBinarySearch()
        {
            ls = [];
        }

        public void Add(int a)
        {
            ls.Add(a);
        }

        public int BinarySearch(int  a)
        {
            int l = 0, r = ls.Count-1;
            

            while (l <= r)
            {
                int mid = (l + r) >> 1;

                if (ls[mid] == a)
                {
                    return mid;
                }

                if (ls[mid]  > a)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return -1;  
        }
    }
}
