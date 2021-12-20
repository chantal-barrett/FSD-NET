using System;
using System.IO;
using System.Collections.Generic;

namespace Project1
{
    class Program
    {
        private static string filename = "C:\\Users\\barrec5\\OneDrive - Dell Technologies\\Documents\\FSD_NET\\FSD-NET\\Project1\\Project1\\Teachers.txt";
        private static List<Teacher> teachers = new List<Teacher>();
        private string Filename
        {
            get { return filename; }
        }
        private List<Teacher> Teachers
        {
            get { return teachers;  }
        }
        static void Main(string[] args)
        {
            if (File.Exists(filename))
            {
                string[] teachersArray = File.ReadAllLines(filename);
                Array.Sort(teachersArray);

                for (int i = 0; i < teachersArray.Length; i++)
                {
                    string[] teacherInfo = teachersArray[i].Split(',');
                    Teacher newTeacher = new Teacher();
                    newTeacher.ID = teacherInfo[0];
                    newTeacher.FirstName = teacherInfo[1];
                    newTeacher.LastName = teacherInfo[2];
                    teachers.Add(newTeacher);
                }

                Console.WriteLine("Would you like to update a teacher's profile (U), list all teachers (L), or sort the teachers (S)?");
                string option = Console.ReadLine().ToLower();
                if(option.Equals("u"))
                {
                    updateTeacher();
                }
                else if (option.Equals("s"))
                {
                    sortTeachers();
                }
                else if (option.Equals("l"))
                {
                    listAllTeachers();
                }

            }
            else
            {
                Console.WriteLine("Cannot find file: " + filename);
            }

        }

        public static void sortTeachers()
        {
            Console.WriteLine("Would you like to sort by ID (I), First Name (F), or Last Name (L): ");
            string sortType = Console.ReadLine().ToLower();

            if (sortType.Equals("i"))
            {
                teachers.Sort(delegate (Teacher t1, Teacher t2)
                {
                    return t1.ID.CompareTo(t2.ID);
                });

                listAllTeachers();
            }
            else if (sortType.Equals("f"))
            {
                teachers.Sort(delegate (Teacher t1, Teacher t2)
                {
                    return t1.FirstName.CompareTo(t2.FirstName);
                });

                listAllTeachers();
            }
            else if (sortType.Equals("l"))
            {
                teachers.Sort(delegate (Teacher t1, Teacher t2)
                {
                    return t1.LastName.CompareTo(t2.LastName);
                });

                listAllTeachers();
            }
            else
            {
                Console.WriteLine("Please enter a valid sort type.");
            }
        }

        public static void updateTeacher()
        {
            Console.WriteLine("Please enter the ID of the teacher you would like to update: ");
            string teacherID = Console.ReadLine();
            Program p = new Program();
            
            // Check if a teacher with that ID exists
            Boolean teacherExists = false;
            foreach(Teacher t in teachers)
            {
                if (t.ID == teacherID)
                {
                    teacherExists = true;
                    Console.WriteLine("Please enter the field you would like to update: ID, firstname, or lastname?");
                    string updateField = Console.ReadLine().ToLower();
                    if(updateField == "id")
                    {
                        Console.WriteLine("Please enter the new ID of the teacher: ");
                        t.ID = Console.ReadLine();
                    }
                    else if(updateField == "firstname")
                    {
                        Console.WriteLine("Please enter the new first name of the teacher: ");
                        t.FirstName = Console.ReadLine();
                    }
                    else if (updateField == "lastname")
                    {
                        Console.WriteLine("Please enter the new last name of the teacher: ");
                        t.LastName = Console.ReadLine();
                    }
                }
            }

            if(teacherExists == false)
            {
                Console.WriteLine("Please enter a valid teacher ID");
            }

            // Write to file
            if (File.Exists(filename))
            {
                // Empty the file
                File.WriteAllText(filename, string.Empty);
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (Teacher t in teachers)
                    {
                        string text = t.ID + "," + t.FirstName + "," + t.LastName;
                        sw.WriteLine(text);
                    }
                }
            }
            else
            {
                Console.WriteLine("Cannot find file: " + filename);
            }
        }

        public static void listAllTeachers()
        {
            foreach (Teacher t in teachers)
            {
                Console.WriteLine(t.getInfo());
            }
        }
    }
}
