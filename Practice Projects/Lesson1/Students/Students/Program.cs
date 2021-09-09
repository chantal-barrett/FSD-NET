using System;


namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\barrec5\OneDrive - Dell Technologies\Documents\FSD_NET\FSD-NET\Practice Projects\Lesson1\Students\Students.txt";

            // Print the data only if the file exists
            if (System.IO.File.Exists(file))
            {
                string studentData = System.IO.File.ReadAllText(file);
                Console.WriteLine(studentData);
            }
        }
    }
}
