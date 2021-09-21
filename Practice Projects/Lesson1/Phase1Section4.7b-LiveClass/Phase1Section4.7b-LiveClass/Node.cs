using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._7b_LiveClass
{
    public class Node
    {
        public string Data { get; set; }

        public Node Prev { get; set; }

        public Node Next { get; set; }

        public Node() { }
        public Node(string data)
        {
            Data = data;
        }
    }

}
