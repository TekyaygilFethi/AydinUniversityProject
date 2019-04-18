using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Business.ExceptionFolder
{
    public static class ExceptionOps
    {
        public static string GetExceptionMessage(Exception ex)
        {
            Exception tempException = ex;

            while (tempException.InnerException != null) ex = tempException.InnerException;

            return tempException.Message;
        }

        public static string GetEntityValidationMessage(DbEntityValidationException ex)
        {
            string msg = string.Empty;
            foreach (var eve in ex.EntityValidationErrors)
            {
                //msg+=$"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:\n";

                foreach (var ve in eve.ValidationErrors)
                {
                    msg += ve.ErrorMessage+"\n";
                    //msg+=$"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"";
                }
            }
            return msg;
        }
    }
}
