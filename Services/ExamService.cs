using StudentApp.Domain;
using StudentApp.Repositories.Interfaces;
using StudentApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Services
{
    public class ExamService : IExamService
    {
        private readonly IExamRepository _repositoryExam;

        public ExamService(IExamRepository repositoryExam)
        {
            _repositoryExam = repositoryExam;
        }
        public void Delete(int id)
        {
            try
            {
                _repositoryExam.Delete(id);
                _repositoryExam.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("An error occured while deleting exam! ");
            }
        }

        public IEnumerable<Exam> GetAll()
        {
            try
            {
                return _repositoryExam.GetAll();
            }
            catch (Exception)
            {
                throw new Exception("An error occured while retrieving exams! ");
            }
        }

        public Exam GetById(int id)
        {
            try
            {
                return _repositoryExam.GetById(id);
            }
            catch (Exception)
            {
                throw new Exception("An error occured while retrieving exam! ");
            }
        }

        public void Insert(Exam entity)
        {
            try
            {
                // check if user input is valid

                if (Valid(entity) == false) throw new ArgumentException("Please provide the correct input! ");

                // check if the exam for this student, this course and this date have already been entered

                var examFromDB = _repositoryExam.GetAll()
                                      .FirstOrDefault(e => e.Student.StudentId == entity.Student.StudentId &&
                                                           e.Subject.SubjectId == entity.Subject.SubjectId &&
                                                           e.ExamDate.ToShortDateString().Equals(entity.ExamDate.ToShortDateString()));

           
                if (examFromDB != null)
                    throw new Exception("Exam for this date has already inserted!");

                /*
                 * if the student has already passed the exam, it is necessary to cancel the grade,
                 * in order to enter a new positive grade
                 */

                if (PassedExam(entity) != null)
                {
                    throw new Exception("This student has already passed this subject! Please delete it before inserting new positive grade for this subject exam. ");
                }
                else
                {
                    // insert entity

                    _repositoryExam.Insert(entity);
                    _repositoryExam.SaveChanges();
                }
             
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while inserting exam! "+ex.Message);
            }
        }

        public Exam PassedExam(Exam entity)
        {
            Exam exam = _repositoryExam.PassedExam(entity.Subject.SubjectId, entity.Student.StudentId, entity.Grade);
            if (exam != null && exam.Grade > 5) return exam;
            return null;
        }

        public void Update(Exam entity)
        {
            try
            {
                // check if user input is valid

                if (Valid(entity) == false) throw new ArgumentException("Please provide the correct input! ");

               /*
               * if the student has already passed the exam, it is necessary to cancel the grade,
               * in order to enter a new positive grade
               */

                if (PassedExam(entity) != null)
                {
                    throw new Exception("This student has alredy passed this subject! Please delete it before inserting new grade for this subject exam. ");
                }

                else
                {
                    _repositoryExam.Update(entity);
                    _repositoryExam.SaveChanges();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while updating exam! "+ex.Message);
            }
        }

        public bool Valid(Exam entity)
        {
           bool valid = true;

            /* Student and subject should not be null
             * Exam date should not be null and should be date in the past
             * Grade should not be null and should be between 5 and 10, including 5 and 10
             */

            if (entity.Student == null || entity.Subject == null
                 || string.IsNullOrEmpty(entity.ExamDate.ToString()) || entity.Grade < 5 ||
                 entity.Grade > 10 || entity.ExamDate > DateTime.Now) valid = false;

            return valid;
        }
    }
}
