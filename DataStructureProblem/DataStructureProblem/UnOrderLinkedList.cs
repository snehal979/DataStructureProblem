using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class UnOrderLinkedList
    {
        public void ReadFile(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] words = list.Split(",");
            LinkedListMethod<string> listkedlist = new LinkedListMethod<string>();
            foreach (var data in words)
            {
                listkedlist.Add(data);
            }
            Console.WriteLine("enter search data");
            {
                string serachWord = Console.ReadLine();
                foreach (var data in words)
                {
                    if (data.Equals(serachWord))
                    {
                        listkedlist.SearchName(serachWord);
                        Console.WriteLine(" delect word");
                        listkedlist.Delete(serachWord);
                       
                        listkedlist.Display();
                        return;
                    }
                }
                listkedlist.Add(serachWord);
                listkedlist.Display();
            }
        }
    }
}
