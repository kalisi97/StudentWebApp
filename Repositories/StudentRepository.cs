using Microsoft.EntityFrameworkCore;
using StudentApp.Domain;
using StudentApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Repositories
{
    public class StudentRepository:Repository<Student>,IStudentRepository
    {
        private readonly ApplicationContext _context;
        public StudentRepository(ApplicationContext context):base(context)
        {
            _context = context;
        }

        public Student FindByIndexNumber(string indexNumber)
        {
            var student = _context.Students.FirstOrDefault(s => s.IndexNumber == indexNumber);
            return student;
        }

   
        public override Student GetById(int id)
        {
            return _context.Students.Include(s => s.Exams).FirstOrDefault(s => s.StudentId == id);
        }

    
    }
}
