/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 4:
|
|     Add a method in the class Student, which displays
|     complete information about the student.
|
| Solutions and Guidelines:
|
|     Display on the console in all fields of the class Student,
|     followed by a blank line.
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
        private int phoneNumber = 0;
        private int course = 0;
        public enum Subjects { Math, Physics, Philosophy }
        private Subjects subject;
        public enum Universities { Standford, IBM, Harvard }
        private Universities university;
        public static int instanceCounter = 0;

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
            this.fullName = fullName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.course = course;
            this.subject = subject;
            this.university = university;
            instanceCounter++;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\nStudent Information:");
            Console.WriteLine("-------------------------------------\n");
            Console.WriteLine("  Name: " + this.fullName);
            Console.WriteLine("  E-Mail: " + this.email);
            Console.WriteLine("  Phone Number: " + this.phoneNumber);
            Console.WriteLine("  Course: " + this.course);
            Console.WriteLine("  Study subject: " + this.subject);
            Console.WriteLine("  University: " + this.university);
        }

        public static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("Chewbacca");
            Student student3 = new Student("Han Solo", "hansolo@starmail.com");
            Student student4 = new Student("Anakin Skywalker", "anakinskywalker@starmail.com", 222222222);
            Student student5 = new Student("Luke Skywalker", "lukeskywalker@starmail.com", 1111111111, 10,
                Subjects.Philosophy, Universities.Standford);
            student5.DisplayInfo();
        }
    }
}