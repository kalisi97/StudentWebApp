using StudentApp.Domain;
using StudentApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Repositories
{
    public class SubjectRepository:Repository<Subject>,IRepositorySubject
    {
        private readonly ApplicationContext _context;
        public SubjectRepository(ApplicationContext context):base(context)
        {
            _context = context;
        }

        public Subject GetByTitle(string subject)
        {
            return _context.Subjects.FirstOrDefault(s => s.Title == subject);
        }
    }
}
