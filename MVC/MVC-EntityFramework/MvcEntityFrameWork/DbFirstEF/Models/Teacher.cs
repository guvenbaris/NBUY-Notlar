using System;
using System.Collections.Generic;

#nullable disable

namespace DbFirstEF.Models
{
    public  class Teacher
    {
        public Teacher()
        {
            StudentTeachers = new HashSet<StudentTeacher>();
        }

        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }

        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }
    }
}
