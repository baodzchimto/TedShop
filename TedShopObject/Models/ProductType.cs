﻿using System;
using System.Collections.Generic;

namespace TedShopObject.Models;

public partial class ProductType
{
    public int ProductTypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
