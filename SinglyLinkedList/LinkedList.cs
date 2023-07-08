using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class LinkedList
    {
        Node? head;

        public LinkedList()
        {
            this.head = null;
        }

        public bool IsEmpty()
        {
            return this.head == null;
        }

        public Node? GetHead()
        {
            return head;
        }

        public void InsertFirst(int value)
        {
            Node? temp = head;
            head = new Node(value);
            head.next = temp;
         
        }

        public void InsertAt(int value, int position)
        {
            if (position > this.Length())
            {
                throw new IndexOutOfRangeException("Position Out of Range!");
            }
            if (this.IsEmpty())
            {
                head = new Node(value);
                return;
            }
            Node? temp = head;
            int index = 0;
            while(index+1 != position)
            {
                temp = temp?.next;
                index++;
            }

            Node? node = new Node(value);
            node.next = temp?.next;
            temp.next = node;
        }

        public void InsertLast(int value) { 
            if(this.IsEmpty())
            {
                head = new Node(value);
                return;
            }

            Node? temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = new Node(value);
        }

        public void RemoveFirst()
        {
            Node? temp = head;
            head = temp.next;
        }

        public void RemoveLast()
        {
            Node? temp = head;
            while(temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }

        public void RemoveAt(int position)
        {
            Node? prev = head;
            int i = 0;
            while (i + 1 != position-1)
            {
                prev = prev.next;
                i++;
            }

            prev.next = prev.next.next;
        }

        public void Print()
        {
            Node? temp = head;
            while(temp != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }
        }

        public int Length()
        {
            Node? temp = head;
            int index = 0;

            while(temp != null)
            {
                temp = temp.next;
                index++;
            }

            return index;
        }

        public Node? GetFirst()
        {
            if(this.IsEmpty())
            {
                throw new InvalidOperationException("List Empty!");
            }
            return head;
        }
    }
}
