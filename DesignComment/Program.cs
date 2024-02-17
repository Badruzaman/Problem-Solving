

Console.WriteLine("Hello, World!");


public class TreeNode<T>
{
    public T Data { get; set; }
    public List<TreeNode<T>> Children { get; set; }
    public TreeNode(T data)
    {
        Data = data;
        Children = new List<TreeNode<T>>();
    }
    public void AddChild(T data)
    {
        Children.Add(new TreeNode<T>(data));
    }
    public void PrintTree(int indent = 0)
    {
        Console.WriteLine(new string(' ', indent) + Data);
        foreach (var child in Children)
        {
            child.PrintTree(indent + 4);
        }
    }
}



