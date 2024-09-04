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
                return "";
            
            Node node = Head.getNext();
            string result = Head.getValue().ToString();
            while (node != null)
            {
                result += " -> " + node.getValue().ToString();
                node = node.getNext();
            }
            return result;
        }

        // O(N)
        public int Length()
        {
            int count = 0;
            Node node = Head;
            while (node != null)
            {
                count++;
                node = node.getNext();
            }
            return count;
        }


        // O(N)
        // Method to remove the first value
        public void RemoveValue(int data)
        {
            if (Head == null)
            {
                return;
            }

            if (Head.getValue() == data)
            {
                Head = Head.getNext();
                return;
            }

            Node current = Head;
            Node previous = null;

            while (current != null)
            {
                if (current.getValue() == data)
                {
                    if (current.getNext() == null)
                    { // אם זה האיבר האחרון
                        previous.setNext(null);
                    }
                    else
                    {
                        previous.setNext(current.getNext());
                    }
                    return;
                }
                previous = current;
                current = current.getNext();
            }
        }

        // O(N)
        // Method to remove the first value
        public void RemoveAllValues(int data)
        {
            if (Head == null)
            {
                return;
            }

            // טיפול במקרה אם יש כמה אברים עם אותו ערך בתחילת הרשימה
            while (Head != null && Head.getValue() == data)
            {
                Head = Head.getNext();
            }

            Node current = Head;

            while (current != null && current.getNext() != null)
            {
                if (current.getNext().getValue() == data)
                {
                    current.setNext(current.getNext().getNext());
                }
                else
                {
                    current = current.getNext();
                }
            }
            return;
        }

        // O(N)
        // Method to remove the value in an index
        public void RemoveIndex(int index)
        {
            if (Head == null)
            {
                return;
            }

            if (index == 0)
            {
                Head = Head.getNext();
                return;
            }

            int count = 0;
            Node current = Head;
            Node previous = null;

            while (current != null)
            {
                if (count == index)
                {
                    // אם זה האיבר שמצאנו באינדקס הרצוי, נבצע מחיקה
                    if (previous != null)
                    {
                        previous.setNext(current.getNext());
                    }
                    return;
                }
                previous = current;
                current = current.getNext();
                count++;
            }
        }


        // O(N)
        // Method to find by value
        public int Find(int data)
        {
            int index = 0;
            Node node = Head;
            while (node != null)
            {
                if (node.getValue() == data)
                {
                    return index;
                }
                node = node.getNext();
                index++;
            }
            return -1; // Element not found
        }


        // O(N)
        // Method to insert a value at an indexget a value by  index
        public int Get(int index)
        {
            int count = 0;
            Node node = Head;
            while (node != null)
            {
                if (count == index)
                {
                    return node.getValue();
                }
                node = node.getNext();
                count++;
            }
            return -1; // Index out of range
        }

    }
}
