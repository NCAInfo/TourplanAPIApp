using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

[XmlRoot(ElementName="GetOptionRequest")]
public class GetOptionRequest { 

	[XmlElement(ElementName="User")] 
	public string User { get; set; } 

	[XmlElement(ElementName="Password")] 
	public string Password { get; set; } 

	[XmlElement(ElementName="OptionCode")] 
	public string OptionCode { get; set; } 
[XmlElement(ElementName="Date_From")] 
	public DateTime Date_From {get;set;}
	[XmlElement(ElementName="Date_To")] 
	public DateTime Date_To { get; set; }
}

[XmlRoot(ElementName="Request")]
public class GetOptionRequestRoot { 

	[XmlElement(ElementName="GetOptionRequest")] 
	public GetOptionRequest GetOptionRequest { get; set; } 
}
