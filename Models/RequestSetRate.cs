
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class RequestSetRate
{
    [Key]
    public int Id { get; set; }

    public string Note { get; set; }
    public string Supplier { get; set; }
    public string SupplierName { get; set; }
    public string OptionCode { get; set; }
    public double MarkupPercent { get; set; }
    public double MarkupAmount { get; set; }
    public string Country { get; set; }
    public DateTime DateCreate { get; set; } = DateTime.Now;
    public string CreateBy { get; set; }
    public bool IsPublish { get; set; }
    public DateTime? DatePublish { get; set; }
    public string? PublishBy { get; set; }
    public DateTime Date_From { get; set; }
    public DateTime Date_To { get; set;}
    public string Price_Code { get; set; }
    public string JsonData { get; set; }
    public string JsonMaster { get; set; }

    public DateTime? LastUpdated { get; set; }
   public Status Status { get; set; }
}

public enum Status
{
    New,
    OnProgress,
    WaitingApprove
}