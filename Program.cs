using Practice_Exercises;

Node node = new Node(1);

LinkedList linkedList = new LinkedList(node);

linkedList.Display();

linkedList.Add(2);
linkedList.Add(3);
linkedList.Add(4);

linkedList.Display();

linkedList.RemoveValue(0);
linkedList.RemoveValue(1);

linkedList.Display();
