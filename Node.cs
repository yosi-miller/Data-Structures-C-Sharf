using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Exercises
{
    public class Node
    {
        // O(1)
        private int Value;
        // O(1)
        private Node Next;

        // O(1)
        public Node(int data)
        {
            Value = data;
            Next = null;
        }

        // O(1)
        public int getValue() { return Value; }
        // O(1)
        public Node getNext() { return Next; }

        // O(1)
        public void setValue(int value) { Value = value; }
        // O(1)
        public void setNext(Node next) { Next = next; }
    }

}
