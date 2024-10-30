using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        public int? GetRoleID(int UserID) => UserDao.GetRoleID(UserID);
       
    }
}
