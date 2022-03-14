using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb_2___LINQ.Models
{
    public class StudentTeacher
    {
        [Key]
        public int StudentTeacherID { get; set; }

        public int StudentID { get; set; }
        public Student Student { get; set; }

        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }
    }
}
