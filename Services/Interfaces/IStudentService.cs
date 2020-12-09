using StudentApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Services.Interfaces
{
    public interface IStudentService:IService<Student>
    {
        Student FindByIndexNumber(string indexNumber);

        bool Valid(Student student);
  
    }
}
