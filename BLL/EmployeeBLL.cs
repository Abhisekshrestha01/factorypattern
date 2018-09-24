using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPE;
using FactoryDAL;

namespace BLL
{
    public class EmployeeBLL:IEmployeeBLL
    {
        public int CheckEmp(IEmployeeBO obj)
        {
            IEmployeeDAL obj1 = EmployeeFaDAL.CreateDAL();
            return (obj1.CheckEmployee(obj));
        }
    }
}
