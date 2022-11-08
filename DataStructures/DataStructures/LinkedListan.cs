using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class LinkedListan<T>
    {
        private Node<T> head;   // Head för Linked List och Root för trä

        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.value = value;

            if(head == null)
            {
                head = newNode;
                return;
            }

            Node<T> current;

            for(current = head; current.next != null; current = current.next)
            {

            }

            current.next = newNode;
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.value = value;

            if(head == null)
            {
                head = newNode;
                return;
            }

            Node<T> nextNode = head;

            head = newNode;
            newNode.next = nextNode;
        }

        public void AddAt(T value, int pos)
        {
            Node<T> newNode = new Node<T>();
            newNode.value = value;

            if(head == null && pos == 0)
            {
                head = newNode;
                return;
            }

            if(pos == 0)
            {
                Node<T> nextNode = head;
                head = newNode;
                newNode.next = nextNode;

                return;
            }

            Node<T> current;
            int nodeIndex = 0;
            for(current = head; current.next != null; current = current.next)
            {
                if(nodeIndex + 1 == pos)
                {
                    break;
                }
                nodeIndex++;
            }

            newNode.next = current.next;
            current.next = newNode;
        }

        public void Print()
        {
            for(Node<T> current = head; current != null; current = current.next)
            {
                Console.WriteLine(current.value);
            }
        }

        public T RemoveAt(int remove)
        {
            T value;

            if(head.next == null)
            {
                value = head.value;
                head = null;

                return value;
            }

            Node<T> current;
            int nodeIndex = 0;
            for(current = head; current.next != null; current = current.next) {
                if(nodeIndex + 1 == remove)
                {
                    break;
                }
                nodeIndex++;
            }

            if(remove == 0)
            {
                value = current.value;
                head = current.next;

                return value;
            }

            value = current.next.value;
            current.next = current.next.next;


            return value;

        }

        public T RemoveFirst()
        {
            T value;

            if(head.next == null)
            {
                value = head.value;
                head = null;

                return value;
            }

            value = head.value;
            head = head.next;

            return value;

        }

        public T RemoveLast()
        {
            T value;

            if (head.next == null)
            {
                value = head.value;
                head = null;
                
                return value;
            }

            Node<T> current;
            for (current = head; current.next.next != null; current = current.next)
            {
                
            }

            value = current.next.value;
            current.next = null;

            return value;
        }
    }
}
