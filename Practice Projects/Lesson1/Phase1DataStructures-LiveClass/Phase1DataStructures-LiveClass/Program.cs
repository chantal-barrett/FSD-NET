using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1DataStructures_LiveClass
{
    class Program
    {
        static void Main(string[] args)
        {
            sortStudents();
        }

        public static void sortStudents()
        {
            string filename = "C:\\Users\\barrec5\\OneDrive - Dell Technologies\\Documents\\FSD_NET\\FSD-NET\\Practice Projects\\Lesson1\\Phase1DataStructures\\students.txt";

            if (File.Exists(filename))
            {
                string[] students = File.ReadAllLines(filename);
                Array.Sort(students);

                foreach (string s in students)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("Enter a name to search: ");
                string name = Console.ReadLine();

                foreach(string s in students)
                {
                    string currentName = s.Split(',')[0];

                    if (currentName.ToLower() == name.ToLower())
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else
            {
                Console.WriteLine("Cannot find file: " + filename);
            }
        }

    }
}
