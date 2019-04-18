using AydinUniversityProject.Business.ExceptionFolder;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.Business;
using AydinUniversityProject.Database.Context;
using System;
using System.Data.Entity.Validation;

namespace AydinUniversityProject.Business.UnitOfWorkFolder
{
    public class UnitOfWork : UnitOfWorkBase, IUnitOfWork
    {
        public AydinUniversityProjectContext db;

        public UnitOfWork(AydinUniversityProjectContext db)
        {
            this.db = db;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(db);
        }

        public T GetManager<T>() where T : class
        {
            Type type = typeof(T);
            try
            {
                return (T)Activator.CreateInstance(typeof(T));
            }
            catch
            {
                throw new Exception("Error in manager type!!");
            }
        }

        public TransactionObject Save()
        {
            TransactionObject response = new TransactionObject();
            try
            {
                db.SaveChanges();
                response.IsSuccess = true;
            }
            catch (DbEntityValidationException ex)
            {
                response.IsSuccess = false;
                response.Explanation = ExceptionOps.GetEntityValidationMessage(ex);
            }
            return response;
        }
    }
}
