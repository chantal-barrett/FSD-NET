using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section6._14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create students
            List<Student> students = new List<Student>();
            Student studentOne = new Student();
            studentOne.Name = "Harvey";
            studentOne.ClassName = "Math";
            studentOne.Section = 1;
            students.Add(studentOne);

            Student studentTwo = new Student();
            studentTwo.Name = "Katrina";
            studentTwo.ClassName = "English";
            studentTwo.Section = 2;
            students.Add(studentTwo);

            // Create subjects
            List<Subject> subjects = new List<Subject>();
            Subject subjectOne = new Subject();
            subjectOne.Name = "Math";
            subjectOne.SubjectCode = 1;
            subjectOne.Teacher = "Jessica";
            subjects.Add(subjectOne);

            Subject subjectTwo = new Subject();
            subjectTwo.Name = "English";
            subjectTwo.SubjectCode = 2;
            subjectTwo.Teacher = "Luis";
            subjects.Add(subjectTwo);

            // Create teachers
            List < Teacher > teachers = new List<Teacher>();

            Teacher teacherOne = new Teacher();
            teacherOne.Name = "Jessica";
            teacherOne.ClassName = "Math";
            teacherOne.Section = 1;
            teachers.Add(teacherOne);

            Teacher teacherTwo = new Teacher();
            teacherTwo.Name = "Luis";
            teacherTwo.ClassName = "English";
            teacherTwo.Section = 2;
            teachers.Add(teacherTwo);

            // Display students in a class            
            foreach (Subject sub in subjects)
            {
                Console.WriteLine("Students in class: " + sub.Name);
                foreach (Student s in students)
                {     
                    if (sub.Name == s.ClassName) {                        
                        Console.WriteLine(s.Name);
                    }
                }
            }

            // Display subjects taught by a teacher
            foreach (Subject sub in subjects)
            {
                Console.WriteLine(sub.Name + " is taught by: ");
                foreach (Teacher t in teachers)
                {
                    if (sub.Name == t.ClassName)
                    {
                        Console.WriteLine(t.Name);
                    }
                }
            }
        }
    }
}
