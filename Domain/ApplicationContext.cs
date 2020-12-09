
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Domain
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Exam> Exams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Student

           modelBuilder.Entity<Student>().HasKey(s => s.StudentId);
           //modelBuilder.Entity<Student>().HasAlternateKey(s=>s.IndexNumber);

            //Subject

            modelBuilder.Entity<Subject>().HasKey(s => s.SubjectId);

            //Exam

            modelBuilder.Entity<Exam>().HasKey(s => s.ExamId);

            modelBuilder.Entity<Exam>().HasOne(s => s.Student).WithMany(e => e.Exams)
               // .HasForeignKey(s => s.StudentIndexNumber).HasPrincipalKey(e => e.IndexNumber);
               .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Exam>().HasOne(s => s.Subject).WithMany(e => e.Exams)
            .HasForeignKey(s => s.SubjectId);

        }

    }
}
