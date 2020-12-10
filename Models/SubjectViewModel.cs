using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class SubjectViewModel
    {
        public int  Id { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        [Remote("VerifyTitle", "Subjects")]
        public string Title { get; set; }
    }
}
