using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentApp.Domain;
using StudentApp.Models;
using StudentApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Controllers
{
    public class ExamsController : Controller
    {
        private readonly IExamService _examService;
        private readonly IStudentService _studentService;
        private readonly ISubjectService _subjectService;

        public ExamsController(IExamService examService, IStudentService studentService, ISubjectService subjectService)
        {
            _examService = examService;
            _studentService = studentService;
            _subjectService = subjectService;
        }

        [HttpGet]
        [Route("Exams/GetExams")]

        public List<ExamViewModel> GetExams()
        {
            var exams = _examService.GetAll();
            List<ExamViewModel> returnExams = new List<ExamViewModel>();
            foreach(Exam e in exams)
            {
               
                returnExams.Add(new ExamViewModel
                {
                    ExamId = e.ExamId,
                    StudentId = e.StudentId,
                    Student = e.Student.IndexNumber,
                    SubjectId = e.SubjectId,
                    Subject = e.Subject.Title,
                    ExamDate = e.ExamDate,
                    Grade = e.Grade
                });
            }
      
            return returnExams;
        }

        public ActionResult Index()
        {
            ViewBag.Students = _studentService.GetAll();
            ViewBag.Subjects = _subjectService.GetAll();

            return View();
        }


        [HttpPost]
        public ActionResult Edit([FromBody] ExamViewModel exam)
        {
            try
            {     
                    Exam examToUpdate = _examService.GetById(exam.ExamId);
                    examToUpdate.Grade = exam.Grade;
                    examToUpdate.ExamDate = exam.ExamDate;
                    _examService.Update(examToUpdate);
                    return Json("Updated!");
                
            }
            catch(Exception e)
            {
               return Json(e.Message);
            }
        }


        [HttpDelete("{id}")]
        [Route("Exams/Delete")]
        public ActionResult Delete(int id)
        {
            try
            {
                _examService.Delete(id);
                return Json("Deleted!");
            }
            catch (Exception e)
            {

                return Json(e.Message);
            }
        }

    }
}
