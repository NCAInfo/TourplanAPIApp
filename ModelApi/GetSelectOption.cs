using DiethelmAPI.ModelDb;

public class GetSelectOption
{
    public virtual List<Srv> Service { get; set; } = new List<Srv>();
    public virtual List<Mty> Message { get; set; } = new List<Mty>();
    public virtual List<Db1> PriceSturcture { get; set; } = new List<Db1>();
    public virtual List<Db2> GuideLanguage { get; set; } = new List<Db2>();
    public virtual List<Db3> Tier { get; set; } = new List<Db3>();
    public virtual List<Db4> CashAdvance { get; set; } = new List<Db4>();
    public virtual List<Db5> TaxOut { get; set; } = new List<Db5>();
    public virtual List<Db6> TaxIn { get; set; } = new List<Db6>();
    public virtual List<Markup> Markup { get; set; } = new Markup().GetMarkups();
}

public class Markup
{
    public string Name { get; set; }
    public string Value { get; set; }

    public List<Markup> GetMarkups()
    {
       var ml = new List<Markup>();
        ml.Add(new Markup { Name = "Service", Value = "S" });
        ml.Add(new Markup { Name = "Matrix Lookup", Value = "M" });
        ml.Add(new Markup { Name = "Percentage", Value = "P" });
        ml.Add(new Markup { Name = "None", Value = "N" });


        return ml;
    }
}
