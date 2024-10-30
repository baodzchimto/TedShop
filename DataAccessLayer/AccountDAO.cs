using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TedShopObject;
using TedShopObject.Models;
namespace DataAccessLayer
{
    public class AccountDAO
    {

        public static Account GetAccountByUserName(string userName)
        {
            using var db = new TedShopSystemContext();
            return db.Accounts.FirstOrDefault(c => c.Username.Equals(userName));

        }

    }
}
