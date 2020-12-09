using StudentApp.Domain;
using StudentApp.Repositories.Interfaces;
using StudentApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentApp.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repositoryStudent;

        public StudentService(IStudentRepository repositoryStudent)
        {
            _repositoryStudent = repositoryStudent;
        }
        public void Delete(int id)
        {
            try
            {
                _repositoryStudent.Delete(id);
                _repositoryStudent.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("An error occured while deleting student! ");
            }
        }

        public IEnumerable<Student> GetAll()
        {
            try
            {
                return _repositoryStudent.GetAll();
            }
            catch (Exception)
            {

                throw new Exception("An error occured while retrieving students! ");

            }
        }

        public Student GetById(int id)
        {
            try
            {
                return _repositoryStudent.GetById(id);
            }
            catch (Exception)
            {
                throw new Exception("An error occured while retrieving student! ");
            }
        }

        public void Insert(Student entity)
        {
            try
            {
                //check if user input is valid

                if (Valid(entity) == false) throw new ArgumentException("Please provide correct input!");
               
                //check if there is no student with the same index number

                var student = _repositoryStudent.FindByIndexNumber(entity.IndexNumber);
                if (student != null) throw new Exception("Student with this index number alredy exist!");
               
                //insert student

                _repositoryStudent.Insert(entity);
                _repositoryStudent.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("An error occured while inserting student! "+ex.Message);
            }

        }

        public void Update(Student entity)
        {
            try
            {
                //check if user input is valid

                if (Valid(entity) == false) throw new Exception("Please provide correct input!");

                //find the student on whom the changes need to be applied

                var student = _repositoryStudent.FindByIndexNumber(entity.IndexNumber);

                //check if there is no other student with this index number

                if (student != null && !student.Equals(entity)) throw new Exception("Student with this index number alredy exist!");
               
                //apply changes
                
                    student.City = entity.City;
                    student.FirstName = entity.FirstName;
                    student.LastName = entity.LastName;
                    student.IndexNumber = entity.IndexNumber;
                
                _repositoryStudent.Update(student);

                //save changes
                _repositoryStudent.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while updating student! " + ex.Message);
            }
        }
      
        public bool Valid(Student entity)
        {

            bool valid = true;

            if (String.IsNullOrEmpty(entity.FirstName)
                || String.IsNullOrEmpty(entity.LastName)
                   || String.IsNullOrEmpty(entity.City) 
                      || String.IsNullOrEmpty(entity.IndexNumber))
                valid = false;

            if (!String.IsNullOrEmpty(entity.IndexNumber)
                && Regex.IsMatch(entity.IndexNumber, "^[2]{1}[0]{1}[1-2]{1}[0-9]{1}/[0-9]{4}$") == false)
                return false;

            return valid;
        }
      
        public Student FindByIndexNumber(string indexNumber)
        {
            try
            {
                return _repositoryStudent.FindByIndexNumber(indexNumber);
            }
            catch (Exception)
            {
                throw new Exception("An error occured while retrieving student! ");

            }
        }

    }
}
