using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section6._14
{
    class Subject
    {
        private string name;
        private string teacher;
        private int subjectCode;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public string Teacher
        {
            get { return teacher; }
            set { this.teacher = value; }
        }
        public int SubjectCode
        {
            get { return subjectCode; }
            set { this.subjectCode = value; }
        }
    }
}
