

public class DoublyLinkedList
{
    public Node Head;
    public Node Tail;
    public void SetHead(Node node)
    {
        if(Head == null)
        {
            Head = node;
            Tail = node;
            return;
        }
        InsertBefore(Head, node);
    }
    public void InsertBefore(Node node, Node nodeToInsert)
    {
        if(nodeToInsert == Head && nodeToInsert == Tail)
        {
            return;
        }
    }
}

public class Node
{
    public int value;
    public Node next;
    public Node prev;
    public Node(int value)
    {
        this.value = value; 
    }
}