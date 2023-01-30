

using System.ComponentModel;

Node node = new Node(10);
node.insert(9);
node.insert(11);
node.insert(5);
node.insert(15);
node.insert(17);
//node.print(node);
bool found = node.contains(20);
Console.WriteLine(found);
Console.ReadKey();
public class Node
{
    public Node left;
    public Node right;
    public int value;
    public Node(int value)
    {
        this.value = value; 
    }
    public void insert(int value)
    {
        if(this.value > value)
        {
            if(left == null)
            {
                left = new Node(value);
            }
            else
            {
                left.insert(value);
            }
        }
        else
        {
            if(right == null)
            {
                right = new Node(value);
            }
            else
            {
                right.insert(value);
            }
        }
    }
    public bool contains(int value)
    {
        if(this.value > value)
        {
            if(left == null)
            {
                return false;
            }
            else
            {
                return left.contains(value);
            }
        }
        else if(this.value < value)
        {
            if(right == null)
            {
                return false;
            }
            else
            {
                return right.contains(value);
            }
        }
        else
        {
            return true;
        }
    }
    public void print(Node node)
    {
        if(node != null)
        {
            Console.Write(" " + node.value);
            node.print(node.left);
            node.print(node.right);
        }
    }
}