using StudentApp.Domain;
using StudentApp.Repositories.Interfaces;
using StudentApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly IRepositorySubject _repositorySubject;

        public SubjectService(IRepositorySubject repositorySubject)
        {
            _repositorySubject = repositorySubject;
        }

        public void Delete(int id)
        {
            try
            {
                _repositorySubject.Delete(id);
                _repositorySubject.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("An error occured while deleting subject! ");
            }
        }

        public IEnumerable<Subject> GetAll()
        {
            try
            {
                return _repositorySubject.GetAll();
            }
            catch (Exception)
            {
                throw new Exception("An error occured while retrieving subjects! ");
            }
        }

        public Subject GetById(int id)
        {
            try
            {
                return _repositorySubject.GetById(id);
            }
            catch (Exception)
            {
                throw new Exception("An error occured while retrieving subject! ");
            }
        }

        public Subject GetByTitle(string subject)
        {
            try
            {
                return _repositorySubject.GetByTitle(subject);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while retrieving subject! "+ex.Message);

            }
        }

        public void Insert(Subject entity)
        {
            try
            {
                // check if user input is valid
                if (string.IsNullOrEmpty(entity.Title)) throw new ArgumentException("Please provide the subject title. ");
               
                // check if there is no subject with the same title
                if (_repositorySubject.GetAll().FirstOrDefault(s => s.Title == entity.Title) != null)
                    throw new ArgumentException("This subject already exists in database!");
               
                // insert new subject
                _repositorySubject.Insert(entity);
                _repositorySubject.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while inserting subject! " + ex.Message);
            }
        }

        public void Update(Subject entity)
        {
            try
            {
                // check if user input is valid
                if (string.IsNullOrEmpty(entity.Title)) throw new ArgumentException("Please provide the subject title. ");

                // check if there is no subject with the same title
                if (_repositorySubject.GetAll().FirstOrDefault(s => s.Title == entity.Title) != null)
                    throw new ArgumentException("This subject already exists in database!");
                
                _repositorySubject.Update(entity);
                _repositorySubject.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while updating subject! " + ex.Message);
            }
        }
    }
}
