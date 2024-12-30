using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Algorithm.Searching.LinearSearch
{
    public class MyLinearSearch
    {
        private readonly IList<int> _ls;
        public MyLinearSearch()
        {
            _ls = [];
        }

        public void Add(int a)
        {
            _ls.Add(a);
        }

        public int LinearSearch(int a)
        {
            for (int i = 0; i < _ls.Count; i++)
            {
                if (_ls[i] == a)
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
