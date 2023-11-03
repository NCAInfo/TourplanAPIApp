
using DiethelmAPI.ModelDb;

public class GetPolicy
{
    public int Pol_Id { get; set; }
    public int? OptId { get; set; }
    public string Period { get; set; }
    public string Level { get; set; }
    public string BookingTypes { get; set; }
    public string MarkUp { get; set; }
    public decimal MarkUppc { get; set; }
    public string Comm { get; set; }
    public decimal Commpc { get; set; }
    public List<RuleSet> RuleSets { get; set; } = new List<RuleSet>();
}

public class RuleSet
{
    public int RulId { get; set; }
    public int XlmId { get; set; }
    public string PriceCode { get; set; }
    public int ApplyForm { get; set; }
    public bool DisplayInDay { get; set; }
    public string FeeType { get; set; }
    public decimal FeeAmount { get; set; }
    public int MIN_SCU { get; set; }
    public int MAX_SCU { get; set; }
    public int MIN_ROOMS { get; set; }
    public int MAX_ROOMS { get; set; }
}

public class FeeType
{
    public string Name { get; set; }
    public string Value { get; set; }

    public static IEnumerable<FeeType> FeeTypes()
    {
        List<FeeType> obj = new List<FeeType>();
        obj.Add(new FeeType {  Name = "Percentage", Value = "P" });
        obj.Add(new FeeType { Name = "First Night(s)", Value = "F" });
        obj.Add(new FeeType { Name = "Fixed Amount", Value = "X" });
        obj.Add(new FeeType { Name = "Last Night(s)", Value = "L" });
        obj.Add(new FeeType { Name = "Per Night Average", Value = "A" });
        return obj;
    }
}

