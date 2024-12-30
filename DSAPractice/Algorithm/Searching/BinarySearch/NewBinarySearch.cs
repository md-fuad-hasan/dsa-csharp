using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Algorithm.Searching.BinarySearch
{
    public class NewBinarySearch
    {
        public NewBinarySearch()
        {
            MyBinarySearch bs = new MyBinarySearch();

            bs.Add(3);
            bs.Add(5);
            bs.Add(6);
            bs.Add(7);
            bs.Add(9);

            Console.WriteLine(bs.BinarySearch(3));
            Console.WriteLine(bs.BinarySearch(2));
            Console.WriteLine(bs.BinarySearch(5));
            Console.WriteLine(bs.BinarySearch(6));
            Console.WriteLine(bs.BinarySearch(7));
            Console.WriteLine(bs.BinarySearch(9));
            Console.WriteLine(bs.BinarySearch(10));
        }
    }
}
