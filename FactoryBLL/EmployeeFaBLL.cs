using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPE;
using BLL;

namespace FactoryBLL
{
    public class EmployeeFaBLL
    {
        public static IEmployeeBLL createnew()
        {
            IEmployeeBLL objempbll = new EmployeeBLL();
            return objempbll;
        }
    }
}
