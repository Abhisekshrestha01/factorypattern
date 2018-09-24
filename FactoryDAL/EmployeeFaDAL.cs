using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPE;
using DAL;

namespace FactoryDAL
{
    public class EmployeeFaDAL
    {
        public static IEmployeeDAL CreateDAL()
        {
            IEmployeeDAL objemp = new EmployeeDAL();
            return objemp;
        }
    }
}
