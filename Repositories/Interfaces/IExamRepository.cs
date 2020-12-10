using StudentApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Repositories.Interfaces
{
    public interface IExamRepository : IRepository<Exam>
    {
        Exam PassedExam(int subjectId, int studentId);
    }
}
