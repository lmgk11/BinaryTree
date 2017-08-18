using System;

class Node
{
    public Node left, right;
    public string value;
    public Node(string value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }
}
