using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TedShopObject.Models;

namespace Service
{
    public interface IAccountService
    { 

      
        Account GetAccountByUserName(string userName);
    }
}
