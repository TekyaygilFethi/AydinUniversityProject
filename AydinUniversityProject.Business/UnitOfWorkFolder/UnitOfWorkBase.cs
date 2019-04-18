using AydinUniversityProject.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Business.UnitOfWorkFolder
{
    public class UnitOfWorkBase
    {
        private static AydinUniversityProjectContext db;
        private static readonly object lockObject = new object();


        public static AydinUniversityProjectContext GetContext()
        {
            if (db == null)
            {
                lock (lockObject)
                {
                    if (db == null)
                    {
                        db = new AydinUniversityProjectContext();
                    }
                }
            }

            return db;
        } //silineblir mi?
    }
}
