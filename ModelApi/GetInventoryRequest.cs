// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(Request));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Request)serializer.Deserialize(reader);
// }

using System.Xml.Serialization;

[XmlRoot(ElementName = "GetInventoryRequest")]
public class GetInventoryRequest
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

}

[XmlRoot(ElementName = "Request")]
public class RequestForGetInventory
{

    [XmlElement(ElementName = "GetInventoryRequest")]
    public GetInventoryRequest GetInventoryRequest { get; set; }
}


