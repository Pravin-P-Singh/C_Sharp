using ClassLibraryDeepCopy;
using System;

namespace DeepCopyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] classroom = new Student[3] 
            { 
                new Student(101,"Pravin"),
                new Student(102,"Chirag"),
                new Student(103,"Nikhil")
            };




            Student[] deepCopiedClassroom = new Student[3];
            //Manual Deep Copy
            for(int i = 0; i < classroom.Length; i++)
            {
                deepCopiedClassroom[i] = new Student(classroom[i]);
            }

            Console.WriteLine("Before altering the og array:: ");
            foreach(var student in deepCopiedClassroom)
            {
                Console.WriteLine($"Student Id: {student.StudentId} | Student Name: {student.StudentName}");
            }

            //classroom[0].StudentName = "Jay";

            Console.WriteLine("After altering the og array:: ");

            foreach (var student in deepCopiedClassroom)
            {
                Console.WriteLine($"Student Id: {student.StudentId} | Student Name: {student.StudentName}");
            }

            Console.WriteLine("New way of implementing deep copy i.e Clone");
            Student[] clonedClassroom = new Student[3];
            for(int i = 0; i < clonedClassroom.Length; i++)
            {
                clonedClassroom[i] = (Student)classroom[i].Clone();
            }
            classroom[0].StudentName = "Jay";
            foreach (var student in clonedClassroom)
            {
                Console.WriteLine($"Student Id: {student.StudentId} | Student Name: {student.StudentName}");
            }

        }
    }
}
