using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb_2___LINQ.Models
{
    public class Subject
    {
        [Key]
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
    }
}
