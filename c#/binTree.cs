using System;

class binTree
{
	public Node root;

	public binTree()
	{
		root = null;
	}

	public void put(string x)
	{
		this.root = addToTree(this.root, x);
	}

	public bool contains(string x)
	{
		return exists(root, x);
	}

	public void write()
	{
		printOut(this.root);
	}

	public void printOut(Node root)
        {
		if(root != null)
		{
			printOut(root.left);
			Console.WriteLine(root.value);
			printOut(root.right);
		}
	}

	public static bool exists(Node root, string value)
	{
		if(root != null)
		{
			int c = string.Compare(root.value, value);

			if (c == 0)
			{
				return true;
        	} if (c < 0)
			{
				return exists(root.right, value);
        	} if (c > 0)
        	{                    
				return exists(root.left, value);
			}
		} else	
		{
			return false;
		}
		return false;
	}

	public static Node addToTree(Node root, string value)
	{
            

        if(root == null)
        {
        	return new Node(value);
        } if(exists(root, value))
        {
        	return root;
        }
        int c = string.Compare(root.value, value);
        if (c > 0)
        {
        	root.left = addToTree(root.left, value);
            return root;
        } if ( c < 0)
        {
			root.right = addToTree(root.right, value);
			return root;
		}

		return null;
	}
}
