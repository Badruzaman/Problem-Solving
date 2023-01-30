// 1, 2, 5, 7, 10, 13, 14, 15, 22
int[] arr = { 1, 2, 5, 7, 10, 13, 14, 15, 22 };
BST bst = new BST(0);
//bst.insert(15);
//bst.insert(9);
//bst.insert(5);
//bst.insert(20);
//bst.insert(3);
BST bs1t  = bst.constructMinHeightBst(arr, null, 0, arr.Length - 1);

bst.print(bs1t);
Console.ReadKey();

class BST
{
    public int value { get; set; }
    public BST left { get; set; }
    public BST right { get; set; }
    public BST(int value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }
    public void insert(int value)
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
        else if (this.value < value)
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
    public BST constructMinHeightBst(int[] array, BST bst, int startIdx, int endIdx)
    {
        if (endIdx < startIdx)
        {
            return null;
        }
        int midIdx = (startIdx + endIdx) / 2;
        int valueToAdd = array[midIdx];
        if (bst == null)
        {
            bst = new BST(valueToAdd);
        }
        else
        {
            bst.insert(valueToAdd);
        }
        constructMinHeightBst(array, bst, startIdx, midIdx - 1);
        constructMinHeightBst(array, bst, midIdx + 1, endIdx);
        return bst;
    }
}

