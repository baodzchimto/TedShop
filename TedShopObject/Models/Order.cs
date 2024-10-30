using System;
using System.Collections.Generic;

namespace TedShopObject.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? UsersId { get; set; }

    public DateOnly OrderDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual User? Users { get; set; }
}
