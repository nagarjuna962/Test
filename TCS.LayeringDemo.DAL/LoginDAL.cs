using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.LayeringDemo.BO;

namespace TCS.LayeringDemo.DAL
{
    public class LoginDAL
    {
        public LoginBO ValidateLogin(LoginBO objLoginBO)
        {
            LoginBO objRetLogin = new LoginBO();
            string conStr = "Data Source=ingnrilpsql01; User ID =a37; Password= a37; Initial Catalog = a36;";
            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "usp_tblLogin_ValidateLogin";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserName", objLoginBO.UserName);

            DataSet dsLogin = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dsLogin);

            if (dsLogin != null && dsLogin.Tables.Count > 0 && dsLogin.Tables[0].Rows.Count > 0)
            {
                objRetLogin.UserName = dsLogin.Tables[0].Rows[0]["username"].ToString();
                objRetLogin.Password = dsLogin.Tables[0].Rows[0]["password"].ToString();
                objRetLogin.UserRoleID = Convert.ToInt32(dsLogin.Tables[0].Rows[0]["userRole"].ToString());
            }
            return objRetLogin;
        }

    }
}
