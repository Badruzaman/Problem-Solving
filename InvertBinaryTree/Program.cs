
BST root = new BST(10);
//root.left = new BST(8);
//root.right = new BST(15);
//root.right.left = new BST(12);
//root.right.right = new BST(20);

root.insert(8);
root.insert(15);
root.insert(12);
root.insert(20);
root.print(root);
Console.WriteLine();
bool result  = root.contain(12);
Console.Write(result);
Console.ReadKey();

class BST
{
    public int value;
    public BST left;
    public BST right;
    public BST(int value)
    {
        this.value = value;
    }

    public void insert(int value)
    {
        if (this.value > value)
        {
            if (left != null)
            {
                left.insert(value);
            }
            else
            {
                BST node = new BST(value);
                left = node;
            }
        }
        else
        {
            if (right != null)
            {
                right.insert(value);
            }
            else
            {
                BST node = new BST(value);
                right = node;
            }
        }
    }
    public bool contain(int value)
    {
        if (this.value > value)
        {
            if (left == null)
            {
                return false;
            }
            else
            {
                return left.contain(value);
            }
        }
        else if (this.value < value)
        {
            if (right == null)
            {
                return false;
            }
            else
            {
                return right.contain(value);
            }
        }
        else
        {
            return true;
        }
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