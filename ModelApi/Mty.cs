using System;
using System.Collections.Generic;

namespace DiethelmAPI.ModelDb;

public partial class Mty
{
    public string Code { get; set; }

    public string Description { get; set; }

    public virtual ICollection<Opt> Opts { get; set; } = new List<Opt>();

    public virtual ICollection<Pol> Pols { get; set; } = new List<Pol>();
}
