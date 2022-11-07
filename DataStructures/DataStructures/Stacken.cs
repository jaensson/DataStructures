using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Stacken<T>
    {
        private T[] stack;
        private int count = 0;  // Stack-pekare
        public int Count { get { return count; } }

        public Stacken()
        {
            stack = new T[10];
        }

        public void Push(T value)
        {
            if(count == stack.Length)
            {
                Resize(count + 10);
            }
            stack[count] = value;
            count++;
        }

        private void Resize(int size)
        {
            T[] temp = new T[size];
            Array.Copy(stack, temp, stack.Length);
            stack = temp;
        }

        public T Peek()
        {
            return stack[count - 1];
        }

        public T Pop()
        {
            return stack[--count];
        }
    }
}
