using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Algorithm.Searching.LinearSearch
{
    public class NewLinearSearch
    {
        public NewLinearSearch()
        {
            MyLinearSearch ls = new MyLinearSearch();

            ls.Add(5);
            ls.Add(4);
            ls.Add(7);
            ls.Add(9);
            ls.Add(3);
            ls.Add(2);

            Console.WriteLine(ls.LinearSearch(7));
            Console.WriteLine(ls.LinearSearch(8));
        }
    }
}
