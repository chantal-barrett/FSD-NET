using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._7b_LiveClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunAppSingleList();
            //RunAppDoubleList();

            string[] words = { "this", "is", "some", "random", "sentence" };
            LinkedList<string> sentence = new LinkedList<string>(words); // .NET's doubly linked list
            DisplayList(sentence);
        }

        public static void DisplayList(LinkedList<string> words)
        {
            foreach(string word in words)
            {
                Console.Write(word + " ");
            }
        }

        public static void RunAppDoubleList()
        {
            DoubleLinkedList list = new DoubleLinkedList();
            Node n = new Node("root");
            list.Add(n);

            for (int i = 0; i < 10; i++)
            {
                Node node = new Node(i.ToString());
                list.Add(node);
            }

            Console.WriteLine("Length of double linked list = " + list.Length);
            Node nodeRef = list.MoveRoot();
            Console.WriteLine("Traversing forward..");
            while (nodeRef != null)
            {
                Console.WriteLine(nodeRef.Data);
                nodeRef = list.MoveNext();
            }

            Console.WriteLine("Traversing backwards..");
            nodeRef = list.MovePrevious();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = list.MovePrevious();
            }
        }

        public static void RunAppSingleList()
        {
            SingleLinkedList list = new SingleLinkedList();
            Node n = new Node();
            n.Data = "root";
            list.Add(n);

            for(int i = 0; i < 10; i++)
            {
                Node node = new Node();
                node.Data = i.ToString();
                list.Add(node);
            }

            Console.WriteLine("Length of singly linked list = " + list.Length);
            Node nodeRef = list.Root;
            while(nodeRef != null)
            {
                Console.WriteLine(nodeRef.Data);
                nodeRef = nodeRef.Next;
            }
        }
    }
}
