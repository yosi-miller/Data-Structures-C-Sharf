using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Exercises
{
    public class TreeNode
    {
        public int Value { get; set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }

        public TreeNode(int _value) {
            Value = _value;
            Left = null;
            Right = null;
        }
    }
}
