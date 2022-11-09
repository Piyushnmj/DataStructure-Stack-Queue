using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList()
        {
            this.head = this.tail = null;
        }

        public void Enqueue(int data)
        {
            Node objNode = new Node(data);
            if (this.tail == null)
            {
                this.head = this.tail = objNode;
            }
            else
            {
                this.tail.next = objNode;
                this.tail = objNode;
            }
            Console.WriteLine($"\n{data} inserted into Queue");
        }

        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("\nQueue is Empty");
                return;
            }
            Node temp = this.head;
            this.head = this.tail.next;

            if (this.head == null)
            {
                this.tail = null;
            }
            Console.WriteLine($"\n{temp.data} deleted from Queue");
        }

        public void Display()
        {
            int size = 0;
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("\nQueue is empty");
                return;
            }
            Console.Write("\nQueue => ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                size++;
            }
            Console.WriteLine("\nTotal Elements in Queue: " + size);
        }
    }
}
