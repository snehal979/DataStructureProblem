using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class OrderListcs
    {
        public void ReadFile(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] words = list.Split(",");
            SortedOrderList<int> sorted = new SortedOrderList<int>();
            foreach (var data in words)
            {
                int result = Convert.ToInt32(data);
                sorted.AddNumber(result);
            }
            Console.WriteLine("before sort");
            sorted.Display();
            sorted.SortOrderNode();

            Console.WriteLine("after sort");
            sorted.Display();
        }

    }
}
