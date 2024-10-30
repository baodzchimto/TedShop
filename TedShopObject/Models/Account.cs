using System;
using System.Collections.Generic;

namespace TedShopObject.Models;

public partial class Account
{
    public int? UsersId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public virtual User? Users { get; set; }


    public int? GetUserID()
    {
        return this.UsersId;
    }
}
