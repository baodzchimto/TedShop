using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TedShopObject;
using TedShopObject.Models;
namespace Repository
{
    public interface IAccountRepository
    {
        Account GetAccountByUserName(string userName); 
       

    }
}
