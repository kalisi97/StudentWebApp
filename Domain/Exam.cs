using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Domain
{
    public class Exam
    {
        public int ExamId { get; set; }
        public int SubjectId { get; set; }
        [Required(ErrorMessage = "Please fill out this field.")]
        public Subject Subject { get; set; }
        public int StudentId { get; set; }
        //  public string StudentIndexNumber { get; set; }
        [Required(ErrorMessage = "Please fill out this field.")]
        public Student Student { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        [Range(5,10)]
        public int Grade { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]

        [DataType(DataType.Date)]
        public DateTime ExamDate { get; set; }

    }
}
