using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> items1 = new CustomList<int>() { 1, 3, 5, 7, 9 };
            CustomList<int> items2 = new CustomList<int>() { 2, 4, 8 };
            CustomList<int> items = new CustomList<int>();
            items = items1.Zip(items2);
        }
    }
}
