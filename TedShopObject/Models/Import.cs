using System;
using System.Collections.Generic;

namespace TedShopObject.Models;

public partial class Import
{
    public int ImportId { get; set; }

    public int? StaffId { get; set; }

    public DateOnly ImportDate { get; set; }

    public virtual ICollection<ImportDetail> ImportDetails { get; set; } = new List<ImportDetail>();

    public virtual User? Staff { get; set; }
}
