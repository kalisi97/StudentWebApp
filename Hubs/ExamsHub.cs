using Microsoft.AspNetCore.SignalR;
using StudentApp.Domain;
using StudentApp.Models;
using StudentApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Hubs
{
    public class ExamsHub : Hub
    {
        private readonly IExamService _examService;
        private readonly IStudentService _studentService;
        private readonly ISubjectService _subjectService;

        public ExamsHub(IExamService examService, IStudentService studentService, ISubjectService subjectService)
        {
            _examService = examService;
            _studentService = studentService;
            _subjectService = subjectService;
        }

        public async Task SendMessage(string id, string grade, string examDate, string student, string subject)
        {

            try
            {

                Student studentFromDb = _studentService.FindByIndexNumber(student);
                Subject subjectFromDb = _subjectService.GetByTitle(subject);
                Exam newExam = new Exam()
                {
                    Grade = Int32.Parse(grade),
                    ExamDate = DateTime.Parse(examDate),
                    Student = studentFromDb,
                    Subject = subjectFromDb
                };

                _examService.Insert(newExam);
                await Clients.All.SendAsync("ReceiveMessage");
            }

            catch (Exception ex)
            {
                await Clients.Caller.SendAsync("ReceiveMessageError", ex.Message);
            }
          
        }
    }
}
