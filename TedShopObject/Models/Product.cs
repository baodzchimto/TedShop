using System;
using System.Collections.Generic;

namespace TedShopObject.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? ProductDescription { get; set; }

    public string? ProduceCountry { get; set; }

    public int? ProductTypeId { get; set; }

    public decimal Price { get; set; }

    public decimal? SellPrice { get; set; }

    public string? UseGuide { get; set; }

    public int Quantity { get; set; }

    public virtual ICollection<ImportDetail> ImportDetails { get; set; } = new List<ImportDetail>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ProductType? ProductType { get; set; }
}
