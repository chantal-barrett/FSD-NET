using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._9_LiveClass
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }

        public static void RunApp()
        {
            Stack stack = new Stack();
            Console.WriteLine("length of stack = " + stack.Length);

            if (stack.Peek() == null)
                Console.WriteLine("Stack contains nothing");

            for(int i = 0; i < 10; i++)
            {
                Node n = new Node(i.ToString());
                stack.Push(n);
                Console.WriteLine("length of stack = " + stack.Length);
            }

            Node node = stack.Pop();
            Console.WriteLine("Popped " + node.Data);

            node = stack.Pop();
            Console.WriteLine("Popped " + node.Data);

            Console.WriteLine(stack.ListContents());
        }
    }
}
