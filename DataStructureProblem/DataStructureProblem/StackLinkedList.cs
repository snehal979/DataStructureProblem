using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class StackLinkedList<T>
    {
        Node<T> headtop;
        public StackLinkedList()
        {
            this.headtop = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.headtop == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.headtop;
            }
            this.headtop =node;
            Console.WriteLine("added the stack value "+value);
        }
        public void Display()
        {
            Node<T> temp = this.headtop;
            if (temp ==null)
            {
                Console.WriteLine("stacklist is empty");
            }
            while (temp !=null)
            {
                Console.WriteLine(temp.data +" ");
                temp =temp.next;
            }
        }
        public void peek()
        {
            if (this.headtop==null)
            {
                Console.WriteLine("list is empty");
            }
            Console.WriteLine("{0} is the top of the stack list", this.headtop.data);
        }
        public void Pop()
        {
            if (this.headtop==null)
            {
                Console.WriteLine("list is empty");
            }
            Console.WriteLine("value is pop "+this.headtop.data);
            this.headtop = this.headtop.next;
        }
    }
}


