using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            sortStudents();
        }

        public static void sortStudents()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\students.txt";

            if (File.Exists(filename))
            {
                string[] students = File.ReadAllLines(filename);


                Console.WriteLine(students);

            } else
            {
                Console.WriteLine("Cannot find file: " + filename);
            }
        }
    }
}
