using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Node
    {
        public int value;
        public Node Right;
        public Node Left;

        public Node(int value)
        {
            this.value = value;
            Right = null;
            Left = null;
        }
       
        public void insertData(ref Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);

            }
            else if (node.value < data)
            {
                insertData(ref node.Right, data);
            }

            else if (node.value > data)
            {
                insertData(ref node.Left, data);
            }
        }

        #region отображение
        public void display(Node n)
        {
            if (n == null)
                return;

            display(n.Left);
            Console.Write(" " + n.value);
            display(n.Right);
        }
        #endregion

       
    }
}