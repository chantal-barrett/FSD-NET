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
            string filename = "C:\\Users\\barrec5\\OneDrive - Dell Technologies\\Documents\\FSD_NET\\FSD-NET\\Practice Projects\\Lesson1\\Phase1DataStructures\\students.txt";

            if (File.Exists(filename))
            {
                string[] studentsSorted = bubbleSort(File.ReadAllLines(filename));

                foreach(string s in studentsSorted)
                {
                    Console.WriteLine(s);
                }

            } else
            {
                Console.WriteLine("Cannot find file: " + filename);
            }
        }

        public static string[] bubbleSort(string[] array)
        {
            string temp;
            int smallest;
            for (int i = 0; i < array.Length - 1; i++)
            {
                smallest = i;
                for (int j = i +1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[smallest]) < 0)
                    {
                        smallest = j;
                    }
                }
                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }
            return array;
        }
    }
}
