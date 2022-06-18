using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_New
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcom to LinkedList Program");
            Node node1 = new Node(70);
            Node node2 = new Node(30);
            Node node3 = new Node(56);
            LinkedList list = new LinkedList();
            list.AddNode(node1);
            list.AddNode(node2);
            list.AddNode(node3);
            list.Display();
        }


    }

}