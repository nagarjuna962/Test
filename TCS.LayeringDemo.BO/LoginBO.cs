using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.LayeringDemo.BO
{
    public class LoginBO
    {
        int loginID;

        public int LoginID
        {
            get { return loginID; }
            set { loginID = value; }
        }
        string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        int userRoleID;

        public int UserRoleID
        {
            get { return userRoleID; }
            set { userRoleID = value; }
        }

    }
}
