using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb_2___LINQ.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentGender { get; set; }
        public DateTime StudentDateOfBirth { get; set; }

        public Course Course { get; set; }
    }
}
