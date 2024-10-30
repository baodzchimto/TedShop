using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TedShopObject.Models;

namespace Service
{
    public class AccountService : IAccountService
    {

        private readonly IAccountRepository iAccountRepository;

        public AccountService()
        {
            iAccountRepository = new AccountRepository();
        }
        public Account GetAccountByUserName(string userName)
        {
           return iAccountRepository.GetAccountByUserName(userName);
        }
    }
}
