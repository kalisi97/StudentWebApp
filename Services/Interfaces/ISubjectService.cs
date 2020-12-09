using StudentApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Services.Interfaces
{
    public interface ISubjectService : IService<Subject>
    {
        Subject GetByTitle(string subject);
    }
}
