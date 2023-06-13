using System;
using System.Collections.Generic;

namespace Furniture_Store.Model;

public partial class Price
{
    public int PriceId { get; set; }

    public string? Name { get; set; }

    public int Price1 { get; set; }

    public int Price20 { get; set; }

    public int Price100 { get; set; }
}
