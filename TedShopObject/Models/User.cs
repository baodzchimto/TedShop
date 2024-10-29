using System;
using System.Collections.Generic;

namespace TedShopObject.Models;

public partial class User
{
    public int UsersId { get; set; }

    public string UName { get; set; } = null!;

    public string? UAddress { get; set; }

    public string? Phone { get; set; }

    public int? RoleId { get; set; }

    public string? BankAccount { get; set; }

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    public virtual ICollection<Import> Imports { get; set; } = new List<Import>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Role? Role { get; set; }
}
