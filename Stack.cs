namespace Practice_Exercises
{
    public class Stack
    {
        public Node Head;
        int Lenghe;
        public Stack() { Head = null; }

        public Stack(int head) { Head = new Node(head); }

        // O(1)
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                Lenghe++;
                return;
            }

            newNode.setNext(Head);
            Head = newNode;
            Lenghe++;
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

        // O(1)
        public int? Pop()
        {
            if(Head == null)
                return null;

            int result = Head.getValue();
            Head = Head.getNext();
            Lenghe--;
            return result;
        }

        // O(1)
        public int? Peak()
        {
            if (Head == null)
                return null;

            int result = Head.getValue();
            return result;
        }

        // O(1)
        public int Length()
        {
            return Lenghe;
        }
    }
}
