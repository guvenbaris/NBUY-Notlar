using System;
using System.Collections.Generic;

#nullable disable

namespace DbFirstEF.Models
{
    public  class Student
    {
        public Student()
        {
            StudentTeachers = new HashSet<StudentTeacher>();
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int GradeId { get; set; }

        public virtual Grade Grade { get; set; }
        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }
    }
}
