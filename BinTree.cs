using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Tree
    {
        public Node root;
        public int count;

        public Tree()
        {
            root = null;
            count = 0;
        }
        public bool EmptyRoot()
        {
            return root == null;
        }

        public void Add(int v)
        {
            if (EmptyRoot())
            {
                root = new Node(v);
            }
            else
            {
                root.insertData(ref root, v);
            }

            count++;
        }

       


        public void display()
        {
            if (!EmptyRoot())
                root.display(root);
        }

        #region найти
        public Node Find(int value)
        {
            return this.Find(value, root);
        }


        public Node Find(int value, Node Mother)
        {
            if (Mother != null)
            {
                if (value == Mother.value)
                    return Mother;
                if (value < Mother.value)
                    return Find(value, Mother.Left);
                else
                    return Find(value, Mother.Right);
            }

            return null;
        }
        #endregion

    }
}