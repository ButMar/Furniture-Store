using System;
using System.Collections.Generic;

namespace Furniture_Store.Model;

public class DetailResponse : Detail
{
    public DetailResponse(Detail detail)
    { 
        this.DatailId = detail.DatailId;
        this.Width = detail.Width;
        this.Height = detail.Height;   
        this.Color = detail.Color;
        this.Name = detail.Name;
        this.Count = detail.Count;
    }
    public int? Price { get; set; }
}
