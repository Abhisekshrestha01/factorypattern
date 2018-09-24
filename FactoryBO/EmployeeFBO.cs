using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using TYPE;

namespace FactoryBO
{
    public class EmployeeFBO
    {
        public static IEmployeeBO CheckEmployee(string username, string password)
        {
            IEmployeeBO empBo = new EmployeeBO(username, password);
            return empBo;
        }
    }
}
