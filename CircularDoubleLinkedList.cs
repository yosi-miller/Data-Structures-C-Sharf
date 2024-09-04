using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Exercises
{
    internal class DoubleNode
    {
        internal int Value;
        internal DoubleNode? Prev;
        internal DoubleNode? Next;
        public DoubleNode(int value)
        {
            Value = value;
            Prev = null;
            Next = null;
        }
    }

    internal class CircularDoubleLinkedList
    {
        public DoubleNode _head;
        public int count;
        public CircularDoubleLinkedList()
        {
            _head = null;
            count = 0;
        }
        public void AddLast(int data)
        {
            DoubleNode newNode = new(data);
            if (_head == null)
            {
                _head = newNode;
                return;
            }

            DoubleNode tail = _head.Prev;
            tail.Next = newNode;
            newNode.Prev = tail;
            newNode.Next = _head;
            _head.Prev = newNode;
        }
    }
}
