using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section6._14
{
    class Student
    {
        private string name;
        private string className;
        private int section;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public string ClassName
        {
            get { return className; }
            set { this.className = value; }
        }
        public int Section
        {
            get { return section; }
            set { this.section = value; }
        }
    }
}
