using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class SortedOrderList<T> where T : IComparable<T>
    {
        public Node<T> head = null;
        public Node<T> tail = null;

        public void AddNumber(T data)
        {
            Node<T> NewNode = new Node<T>(data);
            if (head == null)
            {
                head = NewNode;
                tail = NewNode;
            }
            else
            {
                tail.next = NewNode;
                tail = NewNode;
            }
        }
        public void SortOrderNode()
        {
            Node<T> Current = head, index = null;
            T temp;
            if (head == null)
            {
                return;
            }
            else
            {
                while (Current != null)
                {
                    index = Current.next;
                    while (index != null)
                    {
                        if (Current.data.CompareTo(index.data)>0)
                        {
                            temp = Current.data;
                            Current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    Current = Current.next;


                }
            }
        }
        public void Display()
        {
            Node<T> current = head;
            if (head == null)
            {
                Console.WriteLine("list is empy");
                return;
            }
            while (current != null)
            {
                Console.WriteLine(current.data +" ");
                current = current.next;
            }
        }

    }
}


