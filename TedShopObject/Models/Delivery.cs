using System;
using System.Collections.Generic;

namespace TedShopObject.Models;

public partial class Delivery
{
    public int DeliveryId { get; set; }

    public int? OrderId { get; set; }

    public int? StaffId { get; set; }

    public DateOnly DeliveryDate { get; set; }

    public virtual Order? Order { get; set; }

    public virtual User? Staff { get; set; }
}
