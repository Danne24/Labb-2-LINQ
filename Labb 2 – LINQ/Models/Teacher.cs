using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb_2___LINQ.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public string TeacherGender { get; set; }
        public DateTime TeacherDateOfBirth { get; set; }
    }
}
