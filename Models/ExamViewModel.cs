using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class ExamViewModel
    {
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public string Student { get; set; }
        public int SubjectId { get; set; }
        public string Subject { get; set; }
        public int Grade { get;  set; }
        public DateTime ExamDate { get; set; }
    }
}
