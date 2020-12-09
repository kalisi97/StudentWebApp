using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class InsertStudentViewModel
    {

        [Required]
        [RegularExpression("^[2]{1}[0]{1}[1-2]{1}[0-9]{1}/[0-9]{4}$",
            ErrorMessage = "Please enter index number in format 20xx/xxxx for example: 2020/3701")]
        [Remote("VerifyIndexNumber","Students")]
        public string IndexNumber { get; set; }


        [Required(ErrorMessage = "Please fill out this field.")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Please fill out this field.")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Please fill out this field.")]
        public string City { get; set; }

    }
}
