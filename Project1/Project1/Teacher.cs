using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Teacher
    {
        private string id;
        private string firstName;
        private string lastName;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string getInfo()
        {
            return "ID: " + id + " Name: " + firstName + " " + lastName;
        }
    }
}
