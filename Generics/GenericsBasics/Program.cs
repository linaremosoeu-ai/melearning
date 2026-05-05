using System;
using System.Collections.Generic;

namespace GenericsBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "John", Mark = 75 });
            students.Add(new Student { Name = "Jane", Mark = 88 });
            students.Add(new Student { Name = "Doe", Mark = 91 });

            List<Teacher> teachers = new List<Teacher>();

            teachers.Add(new Teacher { Name = "Mr. Smith", Subject = "Math" });
            teachers.Add(new Teacher { Name = "Ms. Johnson", Subject = "Science" });
            teachers.Add(new Teacher { Name = "Mrs. Brown", Subject = "History" });

            Console.WriteLine("Student List:");

            foreach (Student s in students)
            {
                Console.WriteLine($"{s.Name} - {s.Mark}");
            }

            foreach (Teacher t in teachers)
            {
                Console.WriteLine($"{t.Name} - {t.Subject}");
            }

            Console.WriteLine($"\nTotal Students: {students.Count}");
            Console.WriteLine($"\nTotal Teachers: {teachers.Count}");
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Mark { get; set; }

        public override string ToString()
        {
            return $"{Name}: {Mark}";
        }
    }

    class Teacher
    {
        public string Name { get; set; }
        public string Subject { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Subject}";
        }
    }
}