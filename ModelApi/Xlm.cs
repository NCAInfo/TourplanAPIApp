using System;
using System.Collections.Generic;

namespace DiethelmAPI.ModelDb;

public partial class Xlm
{
    public int XlmId { get; set; }

    public int PolId { get; set; }

    public virtual Pol Pol { get; set; }

    public virtual ICollection<Rul> Ruls { get; set; } = new List<Rul>();

    public virtual ICollection<Xmp> Xmps { get; set; } = new List<Xmp>();
}
