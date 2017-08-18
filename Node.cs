using System;
using System.Collections.Generic;
using System.Text;

namespace binTree
{
    
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
}
