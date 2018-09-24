using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TYPE;
using FactoryBO;
using FactoryBLL;

namespace factorypatten
{
    public partial class adduser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            IEmployeeBO obj = EmployeeFBO.CheckEmployee(username, password);
            IEmployeeBLL obj1 = EmployeeFaBLL.createnew();
            obj1.RegisterEmp(obj);
            
        }
    }
}