using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._4_LiveClass
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }

        public static void RunApp()
        {
            //List<string> student3C = new List<string>();
            //student3C.ToArray();

            string[] student3A, student3B;
            student3A = new string[10] {"Rahul", "Sheela", "Mukesh", "Afzal", "Ramesh", "Geeta", "Jason", "Robert", "Gopal", "Meera"};
            student3B = new string[11] { "Pinky", "Rakesh", "Rafi", "Mumtaz", "Derek", "Sukwinder", "Gopi", "Tulsi", "Chandrika", "Ann", "Jim" };
            StringBuilder sb = new StringBuilder();

            string[] courses = new string[6];
            courses[0] = "Physics";
            courses[1] = "Chemistry";
            courses[2] = "Biology";
            courses[3] = "Calculus";
            courses[4] = "Computer Science";

            int[] marks = new int[6] { 67, 90, 80, 55, 71, 92 };

            courses[5] = "Algebra";

            Console.WriteLine("Students of Class 3A:");
            foreach (string s in student3A)
            {
               // Console.WriteLine(s + ", ");
                sb.Append(s + ", ");
            }
            sb.Length -= 2;
            Console.WriteLine(sb.ToString());
            Console.WriteLine("");

            Console.WriteLine("Students of Class 3B:");
            foreach (string s in student3B)
            {
                Console.WriteLine(s + ", ");
            }
            Console.WriteLine("");

            Console.WriteLine("Marks of Kamal:");
            int total = 0;
            for(int i = 0; i < 6; i++)
            {
                total += marks[i];
                Console.WriteLine(courses[i] + " = " + marks[i]);
            }
            Console.WriteLine("Grade Average = " + total + "/600 = " + (total * 100 / 600) + " percent");

        }
    }
}
