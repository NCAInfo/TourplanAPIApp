using System.Xml.Serialization;

[XmlRoot(ElementName="Reply")]
public class ReplyFromSetRate { 

	[XmlElement(ElementName="SetRateReply")] 
	public object SetRateReply { get; set; }

    [XmlElement(ElementName = "ErrorReply")]
    public ErrorReply ErrorReply { get; set; }
}

public class ErrorReply
{
	[XmlElement(ElementName ="Error")]
	public string Error { get; set; }
}