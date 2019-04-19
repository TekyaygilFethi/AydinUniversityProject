using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.Business.EducationComplexManagerData
{
    public class GetPeriodResponseObject
    {
        public Period Period { get; set; }

        public TransactionObject TransactionObject { get; set; }
    }
}
