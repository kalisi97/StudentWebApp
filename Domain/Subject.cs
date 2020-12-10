using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Domain
{
    public class Subject
    {
        public int SubjectId { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public string Title { get; set; }
        public virtual ICollection<Exam> Exams { get;  set; }

    }
}
