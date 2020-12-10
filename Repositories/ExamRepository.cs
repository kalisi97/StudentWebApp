using Microsoft.EntityFrameworkCore;
using StudentApp.Domain;
using StudentApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Repositories
{
    public class ExamRepository:Repository<Exam>,IExamRepository
    {
        private readonly ApplicationContext _context;
        public ExamRepository(ApplicationContext context):base(context)
        {
            _context = context;
        }

        public override IEnumerable<Exam> GetAll()
        {
            return _context.Exams.AsNoTracking().Include(e => e.Student).Include(e => e.Subject).ToList();
        }

        public override Exam GetById(int id)
        {
            return _context.Exams.AsNoTracking().Include(e => e.Student).Include(e => e.Subject)
                .FirstOrDefault(e=>e.ExamId == id);
        }

        public Exam PassedExam(int subjectId, int studentId)
        {
            var exam = _context.Exams.AsNoTracking().ToList().Find(s => s.SubjectId == subjectId
            && s.StudentId == studentId && s.Grade > 5);
            return exam;
        }

    
    }
}
