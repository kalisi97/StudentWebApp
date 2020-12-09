using StudentApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Repositories.Interfaces
{
    public interface IStudentRepository:IRepository<Student>
    {
         Student FindByIndexNumber(string indexNumber);
    }
}
