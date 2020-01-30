using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCS.LayeringDemo.BLL;
using TCS.LayeringDemo.BO;

namespace TCS.LayeringDemo.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            LoginBO objLoginBO = new LoginBO();
            objLoginBO.UserName = txtUName.Text;

            LoginBLL objLoginBLL = new LoginBLL();

            LoginBO objLoginBO2 = objLoginBLL.ValidateLogin(objLoginBO);
            if (objLoginBO2 != null)
            {
                if (objLoginBO2.Password.ToString() == txtPassword.Text)
                {
                    Session["UserName"] = objLoginBO2.UserName;
                    Session["UserRoleID"] = objLoginBO2.UserRoleID;
                    if (objLoginBO2.UserRoleID == 1)
                    {
                        Response.Redirect("WelcomeAdmin.aspx");
                    }
                    else
                    {
                        Response.Redirect("WelcomeGuest.aspx");
                    }
                }
                else
                {
                    // incorrect passowrd
                }
            }
            else
            {

                // username is incorrect
            }
        }
    }
}