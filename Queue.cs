namespace Practice_Exercises
{

    public class Queue
    {
        int Count;
        Node Head;
        Node Tail;
        public Queue()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        // O(1)
        public void Enqueue(int item)
        {
            Node newNode = new Node(item);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;

            }
            else
            {
                Tail.setNext(newNode);
                Tail = newNode;
            }
            Count++;
        }

        // O(1)
        public int? Dequeue()
        {
            if (Head == null)
                return null;

            int value = Head.getValue();
            if (Head == Tail) // כשיש רק אלמנט אחד בתור
            {
                Head = null;
                Tail = null;
            }
            else { Head = Head.getNext(); }

            Count--;
            return value;
        }

        // O(1)
        public int? Peek()
        {
            if (Head == null)
                return null;

            return Head.getValue();
        }

        // O(1)
        public int GetCount()
        {
            return Count;
        }
    }
}
