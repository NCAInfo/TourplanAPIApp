// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(Request));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Request)serializer.Deserialize(reader);
// }


using System.Xml.Serialization;

public class GetRateRequest { 
	public string User {get;set;} 
	public string Password {get;set;} 
	
	public string OptionCode {get;set;} 
	public DateTime? Date_From {get;set;} 
	public DateTime? Date_To{get;set;}

	public string SupplierName { get;set;}
}
[XmlRoot(ElementName="Request")]
public class RequestForGetRate { 
	public GetRateRequest GetRateRequest {get;set;}  
}