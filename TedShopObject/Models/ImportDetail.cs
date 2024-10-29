using System;
using System.Collections.Generic;

namespace TedShopObject.Models;

public partial class ImportDetail
{
    public int ImportId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public virtual Import Import { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
