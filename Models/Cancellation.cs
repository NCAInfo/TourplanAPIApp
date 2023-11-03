
using System.ComponentModel.DataAnnotations;

public class Cancellation
    {
    [Key]
    public int Id { get; set; }
    public string Country {  get; set; }
    public int polid {  get; set; }
    public string JsonData { get; set; }
    public Status Status { get; set; }
    public string CreateBy { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsPublish { get; set; }
    public DateTime? DatePublish { get; set;}
    public string PublishBy { get; set; }
}

