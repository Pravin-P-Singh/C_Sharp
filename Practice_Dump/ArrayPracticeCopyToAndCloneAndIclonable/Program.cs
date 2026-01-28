using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracticeCopyToAndCloneAndIclonable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] classroom = new Student[3]
            {
                new Student(){StudentId = 101, StudentName="Pravin"},
                new Student(){StudentId = 102, StudentName="Nikhil"},
                new Student(){StudentId = 103, StudentName="Chirag"}
            };
            //CopyTo
            Student[] Tution = new Student[3];
            classroom.CopyTo(Tution, 0);
            Console.WriteLine("Before Changes in the source array");

            //Clone
            Student[] clonedClassroomCopy;
            clonedClassroomCopy = (Student[])classroom.Clone();
            //for (int i = 0; i < classroom.Length; i++)
            //{
            //    int id = int.Parse(Console.ReadLine());
            //    string name = Console.ReadLine();
            //    classroom[i] = new Student()
            //    {
            //        StudentId = id,
            //        StudentName = name
            //    };
            //}

            foreach (var student in classroom)
            {
                Console.WriteLine($"Student Id:{student.StudentId} | Student Name: {student.StudentName}");
            }

            //CopyTo and Clone
            
            foreach(var student in Tution)
            {
                Console.WriteLine($"Student id: {student.StudentId} | Student name: {student.StudentName}");
            }

            classroom[0].StudentName = "Chirag";
            Console.WriteLine("After changes in the source array");
            foreach (var student in Tution)
            {
                Console.WriteLine($"Student id: {student.StudentId} | Student name: {student.StudentName}");
            }

            foreach (var student in Tution)
            {
                Console.WriteLine($"Student id: {student.StudentId} | Student name: {student.StudentName}");
            }


        }
    }
}
