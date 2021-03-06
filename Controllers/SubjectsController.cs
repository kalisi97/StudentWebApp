﻿using Microsoft.AspNetCore.Http;
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
    public class SubjectsController : Controller
    {

        private readonly ISubjectService _subjectService;

        public SubjectsController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

    
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("Subjects/GetAll")]
        public IEnumerable<Subject> GetAll()
        {
            return _subjectService.GetAll();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create([FromForm] Subject subjectViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Subject subject = new Subject()
                    {
                        Title = subjectViewModel.Title
                    };
                    _subjectService.Insert(subject);
                    return RedirectToAction("Index");
                }
                return Create(subjectViewModel);
            }
            catch(Exception e)
            {
                return View("Error", new ErrorViewModel { ExceptionMessage = e.Message });
            }
        }



        [HttpPost]
        [Route("Subjects/Edit")]
        public ActionResult Edit([FromBody] Subject subject)
        {
            try
            {
                _subjectService.Update(subject);
                return Json($"Subject successfully updated!");

            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }


        [HttpDelete("{id}")]
        [Route("Subjects/Delete")]
        public ActionResult Delete(int id)
        {
            try
            {
                _subjectService.Delete(id);
                return Json("Deleted!");
            }
            catch (Exception e)
            {

                return Json(e.Message);
            }
        }


        [AcceptVerbs("Get", "Post")]
        public IActionResult VerifyTitle(string title)
        {


            if (_subjectService.GetByTitle(title) != null)
            {
                return Json($"This subject already exists!");
            }

            return Json(true);
        }
    }
}
