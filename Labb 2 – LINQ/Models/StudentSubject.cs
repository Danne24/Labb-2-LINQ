using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb_2___LINQ.Models
{
    public class StudentSubject
    {
        [Key]
        public int StudentSubjectID { get; set; }

        public int StudentID { get; set; }
        public Student Student { get; set; }

        public int SubjectID { get; set; }
        public Subject Subject { get; set; }
    }
}
