using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{

    public class Hashing
    {
        LinkedListMethod<int>[] arr = new LinkedListMethod<int>[11];
        List<int> linkedlist = new List<int>();

        public Hashing()
        {
            for (int i = 0; i< arr.Length; i++)
            {
                arr[i] = new LinkedListMethod<int>();
            }
        }
        public void ReadTxtFile(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] words = list.Split(' ');
            foreach (var data in words)
            {
                int result = Convert.ToInt32(data);
                linkedlist.Add(result);
            }
        }
        public void Operation()
        {
            foreach (var data in linkedlist)
            {
                arr[data%11].Add(data);
            }
        }
        public void DisplayLinkedlist()
        {
            for (int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine("Slot"+i+"\n");
                arr[i].Display();
            }
        }
    }


}
