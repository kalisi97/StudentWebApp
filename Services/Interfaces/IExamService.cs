using StudentApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Services.Interfaces
{
    public interface IExamService:IService<Exam>
    {
        bool Valid(Exam entity);

        Exam PassedExam(Exam entity);
    }
}
