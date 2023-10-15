

using System.Xml.Serialization;



[XmlRoot(ElementName = "Reply")]
public class ReplyFromSetInventory
{
    [XmlElement(ElementName = "SetInventoryReply")]
    public string SetInventoryReply { get; set; }
    [XmlElement(ElementName = "ErrorReply")]
    public ErrorReply ErrorReply { get; set; }
}


