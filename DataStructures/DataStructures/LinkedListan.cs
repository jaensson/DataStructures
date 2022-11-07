using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class LinkedListan<T>
    {
        /* TODO:
         * AddFirst(), ska sätta in value på första positionen
         * Add(), ska sätta in value på valfri plats
         * Remove(), ska ta bort på valfri plats
         */
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

        public void Print()
        {
            for(Node<T> current = head; current != null; current = current.next)
            {
                Console.WriteLine(current.value);
            }
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
