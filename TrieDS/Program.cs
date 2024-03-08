
Trie trie = new Trie();
trie.Insert("hello");
trie.Insert("world");
trie.Insert("apple");
trie.Insert("banana");

Console.WriteLine(trie.Search("hello"));   // Output: True
Console.WriteLine(trie.Search("world"));   // Output: True
Console.WriteLine(trie.Search("apple"));   // Output: True
Console.WriteLine(trie.Search("banana"));  // Output: True
Console.WriteLine(trie.Search("orange"));  // Output: False
Console.ReadKey();

class TrieNode
{
    public Dictionary<char, TrieNode> Children { get; set; }
    public bool IsEndOfWord { get; set; }
    public TrieNode()
    {
        Children = new Dictionary<char, TrieNode>();
        IsEndOfWord = false;
    }
}
class Trie
{
    private TrieNode root;
    public Trie()
    {
        root = new TrieNode();
    }
    public void Insert(string word)
    {
        TrieNode current = root;
        foreach (char c in word)
        {
            if (!current.Children.ContainsKey(c))
            {
                current.Children[c] = new TrieNode();
            }
            current = current.Children[c];
        }
        current.IsEndOfWord = true;
    }
    public bool Search(string word)
    {
        TrieNode current = root;
        foreach (char c in word)
        {
            if (!current.Children.ContainsKey(c))
            {
                return false;
            }
            current = current.Children[c];
        }
        return current.IsEndOfWord;
    }
}
