using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.LayeringDemo.BO;
using TCS.LayeringDemo.DAL;

namespace TCS.LayeringDemo.BLL
{
    public class LoginBLL
    {
        LoginDAL objLoginDAL = new LoginDAL();
        public LoginBO ValidateLogin(LoginBO objLoginBO)
        {
            return objLoginDAL.ValidateLogin(objLoginBO);
        }
    }
}
