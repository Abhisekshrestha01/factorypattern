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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            IEmployeeBO objBO = EmployeeFBO.CheckEmployee(username, password);
            IEmployeeBLL objBLL = EmployeeFaBLL.createnew();
            int check = objBLL.CheckEmp(objBO);
            if(check == 1)
            {
                Label3.Text = "Successfully loggedIn";
            }
            else
            {
                Label3.Text = "Login notSuccessfull";
            }

        }
    }
}