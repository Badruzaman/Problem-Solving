

Node graph = new Node("A");
graph.AddChild("B").AddChild("C").AddChild("D");
graph.children[0].AddChild("E").AddChild("F");
graph.children[0].children[1].AddChild("I").AddChild("J");
graph.children[2].AddChild("G").AddChild("H");
graph.children[2].children[0].AddChild("K");

var result = graph.BreadthFirstSearch(new List<string>());
foreach (var item in result)
{
    Console.WriteLine(item);
}
Console.ReadKey();

public class Node
{
    public string Name;
    public List<Node> children = new List<Node>();
    public Node(string name)
    {
        this.Name = name;   
    }
    public List<string> BreadthFirstSearch(List<string> array)
    {
        Queue<Node> queue = new Queue<Node>();
        var val = this;
        queue.Enqueue(this);
        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            array.Add(current.Name);
            current.children.ForEach(it => queue.Enqueue(it));
        }
        return array;
    }
    public Node AddChild(string name)
    {
        Node child = new Node(name);
        children.Add(child);
        var val = this;
        return this;
    }
}