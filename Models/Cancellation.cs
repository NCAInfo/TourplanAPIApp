
using System.ComponentModel.DataAnnotations;

public class Cancellation
    {
    [Key]
    public int Id { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    public string Country {  get; set; }
    public string SupplierCode { get; set; }
    public string OptionName { get; set; }
    public int polid { get; set; }
    public string JsonGetPolicy { get; set; }
    public string JsonData { get; set; }
    public Status Status { get; set; }
    public string CreateBy { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? LastUpdated { get; set; }
    public bool IsPublish { get; set; }
    public DateTime? DatePublish { get; set;}
    public string PublishBy { get; set; }
    public string JsonOptionApply { get; set; }
}

