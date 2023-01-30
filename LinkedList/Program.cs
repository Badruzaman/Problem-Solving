



LinkedList linklist = new LinkedList();
linklist.AddToFront(10);
linklist.AddToFront(16);
linklist.AddToFront(32);
linklist.print();
Console.ReadKey();


class Node
{
    public int value;
    public Node next;
    public Node(int value)
    {
        this.value = value;
        this.next = null;
    }
}
class LinkedList
{
    Node head;
    int count;
    public LinkedList()
    {
        this.count = 0;
        this.head = null;
    }
    public void AddToFront(int value)
    {
        Node node = new Node(value);
        node.next = head;
        head = node;
        count++;

    }
    public void print()
    {
        Node runner = head;
        while (runner != null)
        {
            Console.WriteLine(runner.value);
            runner = runner.next;
        }
    }
}