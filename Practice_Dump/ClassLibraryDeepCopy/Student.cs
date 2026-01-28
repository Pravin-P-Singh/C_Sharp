using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDeepCopy
{
    public class Student : ICloneable
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public Student(int studentId, string studentName)
        {
            this.StudentId = studentId;
            this.StudentName = studentName;
        }
        public Student (Student other)
        {
            this.StudentId = other.StudentId;
            this.StudentName = other.StudentName;
        }

        public object Clone()
        {
            return new Student(this.StudentId, this.StudentName);
        }

        
    }
}
