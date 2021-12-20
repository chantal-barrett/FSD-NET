using System;

namespace NuGetProjectPackageCB
{
    public struct Teacher
    {
        public string Name;
        public string ClassName;
        public string Section;

        public string getTeacher()
        {
            return "Teacher Name: " + Name + " Class: " + ClassName + " Section: " + Section;
        }
    }

    public struct Student
    {
        public string Name;
        public string ClassName;
        public string Section;

        public string getStudent()
        {
            return "Student Name: " + Name + " Class: " + ClassName + " Section: " + Section;
        }
    }

    public struct Subject
    {
        public string Name;
        public string SubjectCode;

        public string getSubject()
        {
            return Name + " Code: " + SubjectCode;
        }
    }

}
