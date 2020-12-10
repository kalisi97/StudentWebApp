using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Domain;
using StudentApp.Models;
using StudentApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {

            return _studentService.GetAll();
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([FromForm] InsertStudentViewModel studentViewModel)
        {
            try
            {
                if(ModelState.IsValid)
                {

                    Student student = new Student()
                    {
                        City = studentViewModel.City,
                        FirstName = studentViewModel.FirstName,
                        LastName = studentViewModel.LastName,
                        IndexNumber = studentViewModel.IndexNumber
                    };
                    _studentService.Insert(student);
                    return RedirectToAction("Index", "Home");

                }
                return View(studentViewModel);
            }
            catch(Exception e)
            {
                return View("Error", new ErrorViewModel { ExceptionMessage = e.Message});
            }
        }

        [HttpPost]
        [Route("Students/Edit")]
        public ActionResult Edit([FromBody] Student student)
        {
            try
            {
              
                _studentService.Update(student);
       
                return Json($"Student successfully updated!");
            
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }


        [HttpDelete("{id}")]
        [Route("Students/Delete")]
        public ActionResult Delete(int id)
        {
            try
            {
                _studentService.Delete(id);
                return Json("Deleted! ");
            }
            catch (Exception e)
            {

                return Json(e.Message);
            }
        }


        [AcceptVerbs("Get", "Post")]
        public IActionResult VerifyIndexNumber(string indexNumber)
        {


            if (_studentService.FindByIndexNumber(indexNumber) != null)
            {
                return Json($"Index number {indexNumber} is already in use.");
            }

            return Json(true);
        }

    }
}
