
using System.Xml.Serialization;

public class SetInventoryRequest
    {
    [XmlElement(ElementName = "User")]
    public string User { get; set; }

    [XmlElement(ElementName = "Password")]
    public string Password { get; set; }

    [XmlElement(ElementName = "SupplierCode")]
    public string SupplierCode { get; set; }

    [XmlElement(ElementName = "Date_From")]
    public DateTime Date_From { get; set; }

    [XmlElement(ElementName = "Date_To")]
    public DateTime Date_To { get; set; }

    public Allocation Allocation { get; set; } = new Allocation();
}

