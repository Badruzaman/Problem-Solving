

BST bst = new BST(10);
bst.insert(5);
bst.insert(2);
bst.insert(1);
//bst.insert(5);
//bst.insert(15);
//bst.insert(2);

//bst.insert(13);
//bst.insert(22);
//bst.insert(1);
//bst.insert(14);
bst.contains(1);
//bst.print(bst);
Console.ReadKey();

public class BST
{
    public BST(int value)
    {
        this.value = value;
    }
    public int value { get; set; }
    public BST left { get; set; }
    public BST right { get; set; }
    public BST insert(int value)
    {
        if (this.value > value)
        {
            if (left == null)
            {
                left = new BST(value);
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
                right = new BST(value);
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
            bst.print(bst.left);
            bst.print(bst.right);
        }
    }
    public bool contains(int value)
    {
        if (this.value > value)
        {
            if (left == null)
            {
                return false;
            }
            else
            {
                return left.contains(value);
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
              return right.contains(value);
            }
        }
        else
        {
            return true;
        }

    }
}


