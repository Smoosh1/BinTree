using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.Add(1);
            tree.Add(6);
            tree.Add(2);
            tree.Add(4);
            tree.Add(5);
            tree.Add(3);

            tree.display();
            Node node = tree.Find(5);
            Console.WriteLine();
            Console.WriteLine(node);
            Console.ReadLine();
        }
    }
}
