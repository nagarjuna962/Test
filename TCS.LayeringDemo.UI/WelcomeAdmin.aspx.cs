using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TCS.LayeringDemo.UI
{
    public partial class WelcomeAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null && Session["UserRoleID"] != null && Session["UserRoleID"].ToString() == "1")
            {
                lblMessage.Text = "Welcome" + Session["UserName"].ToString();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}