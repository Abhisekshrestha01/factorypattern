using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYPE
{
    public interface IEmployeeBLL
    {
        int CheckEmp(IEmployeeBO obj);
        void RegisterEmp(IEmployeeBO obj);
    }
}
