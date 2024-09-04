namespace Practice_Exercises
{
    public class BinaryTree
    {
        public TreeNode Root;
        public BinaryTree() { Root = null; }

        public void Insert(int value)
        {
            Root = InsertRecursive(Root, value);
        }

        private TreeNode InsertRecursive(TreeNode node, int value)
        {
            if (node == null)
            {
                node = new TreeNode(value);
                return node;
            }

            if (value < node.Value)
                node.Left = InsertRecursive(node.Left, value);
            else // if value >= node.Value
                node.Right = InsertRecursive(node.Right, value);
            return node;
        }

        public bool Find(int value)
        {
            return FindRecursive(Root, value);
        }

        private bool FindRecursive(TreeNode node, int value)
        {
            if (node == null)
                return false;

            if (value == node.Value)
                return true;
            else if (value < node.Value)
                return FindRecursive(node.Left, value);
            else // if value >= node.Value
                return FindRecursive(node.Right, value);
        }

        public int? GetMax()
        {
            TreeNode root = Root.Right;
            while (root.Right != null)
            {
                if (root.Right == null)
                    return -1;
                root = root.Right;
            }
            return root.Value;
        }

        public int? GetMin()
        {
            if (Root == null)
                return null;

            TreeNode root = Root;
            while (root.Left != null)
            {
                //if (root.Left == null)
                //    return -1;
                root = root.Left;
            }
            return root.Value;
        }
    }
}
