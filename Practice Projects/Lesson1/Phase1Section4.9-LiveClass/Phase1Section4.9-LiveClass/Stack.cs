using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._9_LiveClass
{
    class Stack
    {
        public Node Root { get; private set; }

        public int Length { get; private set; }

        public Node Current { get; private set; }

        public void Push(Node node)
        {
            node.Next = null;
            if(Root == null)
            {
                Root = node;
                Length = 1;
                Current = Root;
                Root.Prev = null;
            }
            else
            {
                Current.Next = node;
                node.Prev = Current;
                Current = node;
                Length++;
            }
        }

        public Node Pop()
        {
            Node ret = null;
            if (Current == null)
            {

            }
            else if (Current == Root)
            {
                ret = Current;
                Current = null;
                Root = null;
                Length = 0;
            }
            else
            {
                ret = Current;
                Current = ret.Prev;
                Current.Next = null;
                Length--;
            }
            return ret;
        }

        public Node Peek()
        {
            Node ret = null;
            if (Current == null)
            {

            }
            else
            {
                ret = Current;
            }
            return ret;
        }

        public string ListContents()
        {
            string ret = "";
            Node iterator = Root;
            while(iterator != null)
            {
                ret += iterator.Data + " ";
                iterator = iterator.Next;
            }
            return ret;
        }
    }
}
