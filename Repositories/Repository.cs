using Microsoft.EntityFrameworkCore;
using StudentApp.Domain;
using StudentApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationContext context;

        public Repository(ApplicationContext context)
        {
            this.context = context;
        }

        public virtual void Delete(int id)
        {
            var entity = context.Set<T>().Find(id);
            context.Remove(entity);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return context.Set<T>().AsNoTracking().ToList();
        }

        public virtual T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public virtual void Insert(T entity)
        {
            context.Add(entity);
        }

        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            context.Entry<T>(entity).State = EntityState.Modified;
        }
    }
}
