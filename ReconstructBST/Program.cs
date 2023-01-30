



int[] arr = { 10, 4, 2, 1, 5, 17, 19, 18 };
BST root = new BST(arr[0]);
for (int i = 1; i < arr.Length; i++)
{
    root.insert(arr[i]);
}
root.print(root);
Console.ReadKey();

public class BST
{
    public int value { get; set; }
    public BST left { get; set; }
    public BST right { get; set; }
    public BST(int value)
    {
        this.value = value;
    }
    public BST insert(int value)
    {
        if (this.value > value)
        {
            if (left == null)
            {
                BST newNode = new BST(value);
                left = newNode;
            }
            else
            {
                left.insert(value);
            }
        }
        else
        {
            if (right == null)
            {
                BST newNode = new BST(value);
                right = newNode;
            }
            else
            {
                right.insert(value);
            }
        }
        return this;
    }
    public void print(BST bst)
    {
        if (bst != null)
        {
            Console.Write(bst.value + " ");
            print(bst.left);
            print(bst.right);
        }
    }
}
