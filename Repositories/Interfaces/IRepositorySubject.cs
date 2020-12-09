using StudentApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Repositories.Interfaces
{
    public interface IRepositorySubject : IRepository<Subject>
    {
        Subject GetByTitle(string subject);
    }
}
