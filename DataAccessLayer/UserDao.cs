using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TedShopObject.Models;

namespace DataAccessLayer
{
    public class UserDao
    {

        public static int? GetRoleID(int userid) {

            using var db = new TedShopSystemContext(); 
           var user = db.Users.FirstOrDefault(u=>u.UsersId == userid);
            if (user == null)
            {
                return -1;
            }
            return user.RoleId;

        }
    }
}
