﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYPE
{
    public interface IEmployeeDAL
    {
        int CheckEmployee(IEmployeeBO obj);
        void Register(IEmployeeBO obj);
    }
}
