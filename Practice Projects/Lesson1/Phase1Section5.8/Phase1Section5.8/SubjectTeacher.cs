using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._8
{
    class SubjectTeacher: Teacher
    {
        private SubjectTeacher whichSubject;

        public SubjectTeacher WhichSubject
        {
            get { return whichSubject; }
            set { whichSubject = value; }
        }
    }
}
