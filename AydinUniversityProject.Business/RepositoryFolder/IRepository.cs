using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Business.RepositoryFolder
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        T GetByID(int ID);
        List<T> GetAll();
        List<T> GetBy(Expression<Func<T, bool>> predicate);
        T SingleGetBy(Expression<Func<T, bool>> predicate);
        void Attach(T item);
    }
}
