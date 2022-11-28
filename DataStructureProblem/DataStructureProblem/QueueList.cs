using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    
        internal class QueueList<T>
        {
            Node<T> top = null;
            public void enqueue(T data)
            {
                Node<T> node = new Node<T>(data);
                if (this.top == null)
                {
                    this.top = node;
                }
                else
                {
                    Node<T> temp = top;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;

                }
                Console.WriteLine("instered into queue linked list "+node.data);

            }
            public void Display()
            {
                Node<T> temp = top;
                if (temp == null)
                {
                    Console.WriteLine(" ");
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
            public void Dequeue()
            {
                if (this.top == null)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("dequeue from linked list "+this.top.data);
                    this.top = this.top.next;
                }
            }
            public void Peek()
            {
                if (this.top == null)
                {
                    Console.WriteLine("stack is null");
                    return;
                }
                Console.WriteLine("the peek value in stack is "+this.top.data);
            }



        }
    

}

