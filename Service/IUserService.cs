using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IUserService
    {

        int? GetRoleID(int userID);
        int GetRoleID(int? v);
    }
}
