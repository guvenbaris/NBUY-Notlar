using System;
using System.Collections.Generic;

#nullable disable

namespace DbFirstEF.Models
{
    public  class StudentTeacher
    {
        public int StudentsStudentId { get; set; }
        public int TeachersTeacherId { get; set; }

        public virtual Student StudentsStudent { get; set; }
        public virtual Teacher TeachersTeacher { get; set; }
    }
}
