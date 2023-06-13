using System;
using System.Collections.Generic;

namespace Furniture_Store.Model;

public partial class Detail
{
    public int DatailId { get; set; }

    public string Name { get; set; } = null!;

    public int Width { get; set; }

    public int Height { get; set; }

    public string Color { get; set; } = null!;

    public int? Count { get; set; }
}
