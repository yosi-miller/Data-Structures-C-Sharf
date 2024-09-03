using static System.Runtime.InteropServices.JavaScript.JSType;

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


    public class LinkedList
    {
        // O(1)
        public Node? Head;

        // O(1)
        public LinkedList()
        {
            Head = null;
        }

        // O(1)
        public LinkedList(int data)
        {
            Head = new Node(data);
        }

        // O(N)
        // Method to add to  the end of the list
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            // if head not null
            Node nodeHead = Head;
            while (nodeHead.getNext() != null)
            {
                nodeHead = nodeHead.getNext();
            }
            nodeHead.setNext(newNode);
            return;
        }

        // O(N)
        public string Display()
        {
            if (Head == null)
                return "Don't have a value";
            
            Node node = Head.getNext();
            string result = Head.getValue().ToString();
            while (node != null)
            {
                result += "-> " + node.getValue().ToString();
                node = node.getNext();
            }
            return result;
        }

        // O(N)
        public int Length()
        {
            if (Head == null)
                return -1;

            int count = 0;
            Node node = Head.getNext();
            while (node != null)
            {
                count++;
                node = node.getNext();
            }
            return count;
        }

    // Method to remove the first value
        public void RemoveValue(int data)
        {
            if (Head == null)
                { return; }

            Node node = Head;
            while (node.getNext() != null)
            {
                if (node.getValue() == data)
                {
                    node.setNext(node.getNext().getNext());
                    return;
                }
                node = node.getNext();
            }
        }

        // Method to remove the first value
        public void RemoveAllValues(int data)
        {
            if (Head == null)
            { return; }

            Node node = Head;
            while (node.getNext() != null)
            {
                if (node.getValue() == data)
                {
                    node.setNext(node.getNext().getNext());
                }
            }
            return;
        }

        // Method to remove the value in an index
        public void RemoveIndex(int index)
        {
            if (Head == null)
            { return; }

            int count = 0;
            Node node = Head;
            while (node.getNext() != null)
            {
                if (count == index)
                {
                    node.setNext(node.getNext().getNext());
                    return;
                }
            }
        }

        // O(N)
        // Method to find by value
        public bool Find(int data)
        {
            if (Head == null)
            { return false; }

            Node node = Head;
            while (node.getNext() != null)
            {
                if (node.getValue() == data)
                {
                    return true;
                }
                node = node.getNext();
            }
            return false;
        }

        // O(N)
        // Method to insert a value at an indexget a value by  index
        public int Get(int index)
        {
            if (Head == null)
            { return -1; }

            int count = 0;
            Node node = Head;
            while (node.getNext() != null)
            {
                if (count == index)
                {
                    return node.getValue();
                }
                count++;
                node = node.getNext();
            }
            return -1;
        }
    }
}
