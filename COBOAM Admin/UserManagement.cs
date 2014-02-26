using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBOAM_Admin
{
    class UserManagement
    {
        public void Login(string username, string password)
        {
            string query = MySql.GetQuery("UserLogin", username, password);
        }
    }
}
