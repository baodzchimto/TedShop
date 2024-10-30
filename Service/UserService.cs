using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService() { userRepository = new UserRepository(); }
        public int? GetRoleID(int userID)
        {
            return userRepository.GetRoleID(userID);
        }
    }
}
