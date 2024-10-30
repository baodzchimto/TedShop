using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TedShopObject.Models;
using DataAccessLayer;
namespace Repository
{
    public class AccountRepository:IAccountRepository
    {
     
    public  Account GetAccountByUserName(string userName) => AccountDAO.GetAccountByUserName(userName);

       
    }
}
