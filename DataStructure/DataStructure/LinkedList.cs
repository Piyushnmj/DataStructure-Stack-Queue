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

        public LinkedList()
        {
            this.head = null;
        }

        public void Push(int data)
        {
            Node objNode = new Node(data);
            if (head == null)
            {
                objNode.next = null;
            }
            else
            {
                objNode.next = head;
            }
            head = objNode;
            Console.WriteLine($"{data} pushed to Stack");
        }

        public void Display()
        {
            int size = 0;
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("\nStack is empty");
                return;
            }
            Console.Write("\nLinked List => ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                size++;
            }
            Console.WriteLine("\nTotal Elements in Stack: " + size);
        }
    }
}
