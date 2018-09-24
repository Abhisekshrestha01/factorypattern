using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPE;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class EmployeeDAL:IEmployeeDAL
    {
        public int CheckEmployee(IEmployeeBO obj)
        {
            string str = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "logintest";
                cmd.Parameters.AddWithValue("@username", obj.Username);
                cmd.Parameters.AddWithValue("@password", obj.Password);
                conn.Open();
                cmd.Connection = conn;
                int reader = Convert.ToInt32(cmd.ExecuteScalar());
                if (reader > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public void Register(IEmployeeBO obj)
        {
            string str = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Registertest";
                cmd.Parameters.AddWithValue("@username", obj.Username);
                cmd.Parameters.AddWithValue("@password", obj.Password);
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                
            }
        }


    }
}
