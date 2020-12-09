using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Domain
{
    public class Seeder
    {
        private readonly ApplicationContext context;

        public Seeder(ApplicationContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            if(context.Database.CanConnect())
            {
                if(!context.Students.Any())
                {
                    InsertSampleDataStudents();
                }

                if (!context.Subjects.Any())
                {
                    InsertSampleDataSubjects();
                }
            }
        }

        private void InsertSampleDataSubjects()
        {
            List<Subject> subjects = new List<Subject>() 
            {
                new Subject() { Title = "Projektovanje softvera" },
                new Subject() { Title = "Baze podataka" },
                new Subject() { Title = "Engleski 3" },
                new Subject() { Title = "Osnovi organizacije" },
                new Subject() { Title = "Internet tehnologije" },
                new Subject() { Title = "Programski jezici" },
                new Subject() { Title = "Inteligentni sistemi" }
            };
            context.Subjects.AddRange(subjects);
            context.SaveChanges();
        }

        private void InsertSampleDataStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    FirstName = "Pera",
                    LastName = "Peric",
                    IndexNumber = "2020/0001",
                    City = "Nis"
                },
                new Student()
                {
                    FirstName = "Mika",
                    LastName = "Mikic",
                    IndexNumber = "2020/0002",
                    City = "Nis"
                },
                new Student()
                {
                    FirstName = "Nikola",
                    LastName = "Nikolic",
                    IndexNumber = "2020/0009",
                    City = "Kragujevac"
                },
                new Student()
                {
                    FirstName = "Marko",
                    LastName = "Nikolic",
                    IndexNumber = "2020/0019",
                    City = "Kragujevac"
                },
                new Student()
                {
                    FirstName = "Marina",
                    LastName = "Peric",
                    IndexNumber = "2020/0119",
                    City = "Krusevac"
                },
                new Student()
                {
                    FirstName = "Jelena",
                    LastName = "Marinkovic",
                    IndexNumber = "2020/1019",
                    City = "Zrenjanin"
                },
                new Student()
                {
                    FirstName = "Marko",
                    LastName = "Jovanovic",
                    IndexNumber = "2020/0100",
                    City = "Beograd"
                },
                new Student()
                {
                    FirstName = "Ivana",
                    LastName = "Ivanovic",
                    IndexNumber = "2020/0222",
                    City = "Novi Sad"
                }
            };
            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
