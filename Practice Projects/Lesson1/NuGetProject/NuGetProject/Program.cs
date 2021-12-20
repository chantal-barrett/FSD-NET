using NuGetProjectPackageCB;
using System;

namespace NuGetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1;
            s1.Name = "Harvey";
            s1.ClassName = "Computer Science";
            s1.Section = "1";
            Console.WriteLine(s1.getStudent());

            Teacher t1;
            t1.Name = "Rachel Zane";
            t1.ClassName = "Computer Science";
            t1.Section = "1";
            Console.WriteLine(t1.getTeacher());

            Subject subject1;
            subject1.Name = "Computer Science";
            subject1.SubjectCode = "CS100";
            Console.WriteLine(subject1.getSubject());
        }
    }
}
