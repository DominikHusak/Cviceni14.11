using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1411
{
    internal class MyStack<T>
    {
        private Node<T> head;
        private int count;

        public MyStack()
        {
            head = null;
            count = 0;
        }

        public int Count
        {
            get { return count; }
            set { this.count = value; }
        }

        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }

        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (IsEmpty)
            {
                head = node;
                count = 1;
                return;
            }

            node.Next = head;
            head = node;
            count++;
        }

        public Node<T> Pop()
        {
            if (IsEmpty)
            {
                throw new ArgumentNullException("Stack is empty");
            }

            Node<T> node = head;
            head = head.Next;
            count--;

            return node;

        }

        public bool IsEmpty
        {
            get { return head == null; }
        }
    }

    class Node<T>
    {
        private Node<T> next;
        private T value;

        public Node(T value)
        {
            Value = value;
        }

        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public Node<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }

}

