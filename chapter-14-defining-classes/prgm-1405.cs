/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 5:
|
|     Modify the current source code of Student class so as to
|     encapsulate the data in the class using properties.
|
| Solutions and Guidelines:
|
|     Define as private all members of the class Student
|     and then using Visual Studio (Refactor -> Encapsulate Field)
|     define automatically the public get / set methods
|     to access these fields.
|
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Student
    {
        private string fullName = null;
        private string email = null;
        private int phoneNumber;
        private int course = 0;
        public enum Subjects { Math, Physics, Philosophy }
        private Subjects subject;
        public enum Universities { Standford, IBM, Harvard }
        private Universities university;
        public static int instanceCounter = 0;

        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Course { get => course; set => course = value; }
        internal Subjects Subject { get => subject; set => subject = value; }
        internal Universities University { get => university; set => university = value; }

        public Student()
            : this(null) { }

        public Student(string fullName)
            : this(fullName, null) { }

        public Student(string fullName, string email)
            : this(fullName, email, 0) { }

        public Student(string fullName, string email, int phoneNumber)
            : this(fullName, email, phoneNumber, 0, Subjects.Math, Universities.Harvard) { }

        public Student(string fullName, string email, int phoneNumber, int course, Subjects subject, Universities university)
        {
            this.FullName = fullName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Course = course;
            this.Subject = subject;
            this.University = university;
            instanceCounter++;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("\nStudent Information:");
            Console.WriteLine("-------------------------------------\n");
            Console.WriteLine("  Name: " + this.FullName);
            Console.WriteLine("  E-Mail: " + this.Email);
            Console.WriteLine("  Phone Number: " + this.PhoneNumber);
            Console.WriteLine("  Course: " + this.Course);
            Console.WriteLine("  Study subject: " + this.Subject);
            Console.WriteLine("  University: " + this.University);
        }

        public static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("Chewbacca");
            Student student3 = new Student("Han Solo", "hansolo@starmail.com");
            Student student4 = new Student("Anakin Skywalker", "anakinskywalker@starmail.com", 222222222);
            Student student5 = new Student("Luke Skywalker", "lukeskywalker@starmail.com", 1111111111, 10,
                Student.Subjects.Philosophy, Student.Universities.Standford);
            student5.DisplayStudentInfo();
        }
    }
}