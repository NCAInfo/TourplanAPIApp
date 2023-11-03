using System;
using System.Collections.Generic;

namespace DiethelmAPI.ModelDb;

public partial class Srv
{
    public string Code { get; set; }

    public string Name { get; set; }

    public string Analysis1 { get; set; }

    public string Analysis2 { get; set; }

    public string Analysis3 { get; set; }

    public string MessageCode { get; set; }

    public int Button { get; set; }

    public string Analysis4 { get; set; }

    public string Analysis5 { get; set; }

    public string Analysis6 { get; set; }

    public bool HasEndLocation { get; set; }

    public virtual Db1 Analysis1Navigation { get; set; }

    public virtual Db2 Analysis2Navigation { get; set; }

    public virtual Db3 Analysis3Navigation { get; set; }

    public virtual Db4 Analysis4Navigation { get; set; }

    public virtual Db5 Analysis5Navigation { get; set; }

    public virtual Db6 Analysis6Navigation { get; set; }

    public virtual ICollection<Opt> Opts { get; set; } = new List<Opt>();

    public virtual ICollection<Pol> Pols { get; set; } = new List<Pol>();
}
