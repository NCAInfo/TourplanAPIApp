// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(Request));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Request)serializer.Deserialize(reader);
// }

using System.Xml.Serialization;

[XmlRoot(ElementName="SetRateRequest")]
public class SetRateRequest { 

	[XmlElement(ElementName="User")] 
	public string User {get;set;} 

	[XmlElement(ElementName="Password")] 
	public string Password{get;set;}

	[XmlElement(ElementName = "DateRange")]
	public List<DateRange> DateRange { get; set; } = new List<DateRange>();
}

[XmlRoot(ElementName="Request")]
public class RequestForSetRate { 

	[XmlElement(ElementName="SetRateRequest")] 
	public SetRateRequest SetRateRequest{get;set;} = new SetRateRequest();

}

