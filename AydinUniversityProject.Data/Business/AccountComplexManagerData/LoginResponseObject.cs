using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.Business.AccountComplexManagerData
{
    public class LoginResponseObject
    {
        public int ID { get; set; }

        public TransactionObject TransactionObject { get; set; }
    }
}
