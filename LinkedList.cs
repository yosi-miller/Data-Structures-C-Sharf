using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice_Exercises
{
    public class Node
    {
        private int Value;
        private Node Next;

        public Node(int data)
        {
            Value = data;
            Next = null;
        }

        public int getValue() { return Value; }
        public Node getNext() { return Next; }

        public void setValue(int value) { Value = value; }
        public void setNext(Node next) { Next = next; }
    }


    public class LinkedList
    {
        public Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public LinkedList(Node data)
        {
            Head = data;
        }

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


        public void Display()
        {
            if (Head == null)
            {
                Console.WriteLine("Don't have a value");
                return;
            }

            Node node = Head.getNext();
            Console.Write(Head.getValue());
            while (node != null)
            {
                Console.Write(" -> " + node.getValue());
                node = node.getNext();
            }
            //1-> 2-> 5-> - 5-> 5
        }

        public int Length()
        {
            if (Head == null)
                return -1;

            int count = 1;
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
                if (node.getNext().getValue() == data)
                {
                    node.setNext(node.getNext().getNext());
                    return;
                }
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
                if (node.getNext().getValue() == data)
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

        // Method to find by value
        public bool Find(int data)
        {
            if (Head == null)
            { return false; }

            Node node = Head;
            while (node.getNext() != null)
            {
                if (node.getNext().getValue() == data)
                {
                    return true;
                }
                node = node.getNext();
            }
            return false;
        }

        // Method to get a value by  index
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
            }
            return -1;
        }
    }
}
