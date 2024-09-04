namespace Practice_Exercises
{
    public class Stack
    {
        public Node Head;
        int Lenghe;
        public Stack() { Head = null; }

        public Stack(int head) { Head = new Node(head); }

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

        public int Length()
        {
            return Lenghe;
        }
    }
}
