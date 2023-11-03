using System;
using System.Collections.Generic;

namespace DiethelmAPI.ModelDb;

public partial class Xmp
{
    public int XmpId { get; set; }

    public int XlmId { get; set; }

    public string PriceCode { get; set; }

    public virtual Xlm Xlm { get; set; }
}
