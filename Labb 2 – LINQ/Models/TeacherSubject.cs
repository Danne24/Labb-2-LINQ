using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb_2___LINQ.Models
{
    public class TeacherSubject
    {
        [Key]
        public int TeacherSubjectID { get; set; }

        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }

        public int SubjectID { get; set; }
        public Subject Subject { get; set; }
    }
}
