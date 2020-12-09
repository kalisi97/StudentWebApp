using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Domain
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        [RegularExpression("^[2]{1}[0]{1}[1-2]{1}[0-9]{1}/[0-9]{4}$",
            ErrorMessage = "Please enter index number in format 20xx/xxxx for example: 2020/3701")]
        public string IndexNumber { get; set; }


        [Required(ErrorMessage = "Please fill out this field.")]  
        public string FirstName  { get; set; }


        [Required(ErrorMessage = "Please fill out this field.")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Please fill out this field.")]
        public string City  { get; set; }


        public virtual ICollection<Exam> Exams { get; set; }

        public override bool Equals(object obj)
        {
          if (this == obj) return true;

          if (obj is Student s)
          {
                if(s != null)
                {
                    if (s.IndexNumber == this.IndexNumber) return true;
                }
          }

            return false;
        }

        public override int GetHashCode()
        {
            return this.IndexNumber.GetHashCode();
        }
    }
}
