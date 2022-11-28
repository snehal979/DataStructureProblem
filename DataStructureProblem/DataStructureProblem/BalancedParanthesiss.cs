using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class BalancedParanthesiss
    {
        public void ReadFile(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] words = list.Split(" ");
            StackLinkedList<string> sorted = new StackLinkedList<string>();
            foreach (var data in words)
            {
                if (data.Equals("("))
                {
                    sorted.Push(data);
                }
                if (data.Equals(")"))
                {
                    sorted.Pop();
                }
            }
            sorted.peek();
        }

    }
}
