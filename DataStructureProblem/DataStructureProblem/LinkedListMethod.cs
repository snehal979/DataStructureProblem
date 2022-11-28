using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;


        //constructor
        public Node(T data)
        {
            this.data = data;


        }

    }
    public class LinkedListMethod<T>
    {
        public Node<T> head;

        public Node<T> tail;
        /// <summary>
        /// Uc1
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List", node.data);
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data +" ");
                    temp = temp.next;
                }
            }
        }
        public void SearchName(T value)
        {
            Node<T> temp = this.head;
            if (temp.data.Equals(value))
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("not found");

            }

        }
        public void Delete(T head1)
        {
            if (head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            else if (head.next == null)
            {
                head = null;
            }
            else
            {
                Node<T> newNode = head;
                while (newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
                newNode.next = null;
            }
        }


    }
}
