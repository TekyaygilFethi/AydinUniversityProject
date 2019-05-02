using AydinUniversityProject.Database.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AydinUniversityProject.Business.RepositoryFolder
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public AydinUniversityProjectContext db;

        public Repository(AydinUniversityProjectContext db)
        {
            this.db = db;
        }

        public void Add(T item)
        {
            db.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            db.Set<T>().Remove(item);
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public List<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>().Where(predicate).ToList();
        }

        public T GetByID(int ID)
        {
            return db.Set<T>().Find(ID);
        }

        public T SingleGetBy(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>().SingleOrDefault(predicate);
        }
        
        public void Attach(T item)
        {
            db.Set<T>().Attach(item);
        }
    }
}
