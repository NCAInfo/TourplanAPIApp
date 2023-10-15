// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(Reply));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Reply)serializer.Deserialize(reader);
// }

using OneOf.Types;
using System.Xml.Serialization;

[XmlRoot(ElementName="ExtraRates")]
public class ExtraRates { 

	

	[XmlElement(ElementName="Ex1Rate")] 
	public double Ex1Rate { get; set; }
    public bool Ex1Apply { get; set; } = true;

    [XmlElement(ElementName="Ex2Rate")] 
	public double Ex2Rate { get; set; }
    public bool Ex2Apply { get; set; } = true;

    [XmlElement(ElementName="Ex3Rate")] 
	public double Ex3Rate { get; set; }
    public bool Ex3Apply { get; set; } = true;

    [XmlElement(ElementName="Ex4Rate")] 
	public double Ex4Rate { get; set; }
    public bool Ex4Apply { get; set; } = true;

    [XmlElement(ElementName = "Ex5Rate")]
    public double Ex5Rate { get; set; }
    public bool Ex5Apply { get; set; } = true;

    [XmlElement(ElementName = "Ex6Rate")]
    public double Ex6Rate { get; set; }
    public bool Ex6Apply { get; set; } = true;
    [XmlElement(ElementName = "Ex7Rate")]
    public double Ex7Rate { get; set; }
    public bool Ex7Apply { get; set; } = true;
    [XmlElement(ElementName = "Ex8Rate")]
    public double Ex8Rate { get; set; }
    public bool Ex8Apply { get; set; } = true;
    [XmlElement(ElementName = "Ex9Rate")]
    public double Ex9Rate { get; set; }
    public bool Ex9Apply { get; set; } = true;
    [XmlElement(ElementName = "Ex10Rate")]
    public double Ex10Rate { get; set; }
    public bool Ex10Apply { get; set; } = true;
}

[XmlRoot(ElementName="AdultExtras")]
public class AdultExtras { 

	[XmlElement(ElementName="ExtraRates")] 
	public ExtraRates ExtraRates { get; set; } = new ExtraRates();
}

[XmlRoot(ElementName="ChildExtras")]
public class ChildExtras { 

	[XmlElement(ElementName="ExtraRates")] 
	public ExtraRates ExtraRates { get; set; } = new ExtraRates();
}

[XmlRoot(ElementName="InfantExtras")]
public class InfantExtras { 

	[XmlElement(ElementName="ExtraRates")] 
	public ExtraRates ExtraRates { get; set; } = new ExtraRates();
}

[XmlRoot(ElementName="Extras")]
public class Extras { 

	[XmlElement(ElementName="AdultExtras")] 
	public AdultExtras AdultExtras { get; set; } = new AdultExtras();

	[XmlElement(ElementName="ChildExtras")] 
	public ChildExtras ChildExtras { get; set; } = new ChildExtras();

	[XmlElement(ElementName="InfantExtras")] 
	public InfantExtras InfantExtras { get; set; } = new InfantExtras();
}

[XmlRoot(ElementName="Rates")]
public class Rates {

    public bool IsManual { get; set; }

	
    [XmlElement(ElementName="AdultRate")] 
	public double? AdultRate { get; set; }
	public bool AdultRateApply { get; set; } = true;
    [XmlElement(ElementName = "ChildRate")]
    public double ChildRate { get; set; }
    public bool ChildRateApply { get; set; } = true;
    [XmlElement(ElementName = "InfantRate")]
    public double InfantRate { get; set; }
    public bool InfantRateApply { get; set; } = true;
    [XmlElement(ElementName="PaxBreakRate")] 
	public PaxBreakRate? PaxBreakRate {get;set;}

	[XmlElement(ElementName="Extras")] 
	public Extras? Extras { get; set; } 
	[XmlElement(ElementName = "RoomRate")]
	public RoomRate? RoomRate { get; set; } 
}
[XmlRoot(ElementName="RoomRate")]
public class RoomRate{
	[XmlElement(ElementName="SG")] 
	public double? SG { get; set; }
    public bool SGApply { get; set; } = true;
    [XmlElement(ElementName="TW")] 
	public double? TW { get; set; }
    public bool TWApply { get; set; } = true;
    [XmlElement(ElementName="TR")] 
	public double? TR { get; set; }
    public bool TRApply { get; set; } = true;
    [XmlElement(ElementName="QD")] 
	public double? QD { get; set; }
    public bool QDApply { get; set; } = true;
    [XmlElement(ElementName="AA")] 
	public double AA { get; set; }
    public bool AAApply { get; set; } = true;

}

[XmlRoot(ElementName="PaxBreakRate")]
public class PaxBreakRate
{
	[XmlElement(ElementName = "Price_Pxb1")]
	public double Price_Pxb1 { get; set; }
	public bool Price_Pxb1Apply { get; set; } = true;
    [XmlElement(ElementName="Price_Pxb2")] 
	public double Price_Pxb2 {get;set;}
    public bool Price_Pxb2Apply { get; set; } = true;
    [XmlElement(ElementName="Price_Pxb3")] 
	public double Price_Pxb3 {get;set;}
    public bool Price_Pxb3Apply { get; set; } = true;
    [XmlElement(ElementName="Price_Pxb4")] 
	public double Price_Pxb4 {get;set;}
    public bool Price_Pxb4Apply { get; set; } = true;
    [XmlElement(ElementName = "Price_Pxb5")]
    public double Price_Pxb5 { get; set; }
    public bool Price_Pxb5Apply { get; set; } = true;
    [XmlElement(ElementName = "Price_Pxb6")]
    public double Price_Pxb6 { get; set; }
    public bool Price_Pxb6Apply { get; set; } = true;
    [XmlElement(ElementName = "Price_Pxb7")]
    public double Price_Pxb7 { get; set; }
    public bool Price_Pxb7Apply { get; set; } = true;
    [XmlElement(ElementName = "Price_Pxb8")]
    public double Price_Pxb8 { get; set; }
    public bool Price_Pxb8Apply { get; set; } = true;
    [XmlElement(ElementName = "Price_Pxb9")]
    public double Price_Pxb9 { get; set; }
    public bool Price_Pxb9Apply { get; set; } = true;
    [XmlElement(ElementName = "Price_Pxb10")]
    public double Price_Pxb10 { get; set; }
    public bool Price_Pxb10Apply { get; set; } = true;
}

[XmlRoot(ElementName="GroupCost")]
public class GroupCost { 

	[XmlElement(ElementName="Rates")] 
	public Rates Rates { get; set; }  = new Rates();
}

[XmlRoot(ElementName="FITCost")]
public class FITCost { 

	[XmlElement(ElementName="Rates")] 
	public Rates Rates { get; set; } = new Rates();
}

[XmlRoot(ElementName="GroupSell")]
public class GroupSell { 

	[XmlElement(ElementName="Rates")] 
	public Rates Rates { get; set; } = new Rates();
}

[XmlRoot(ElementName="FITSell")]
public class FITSell { 

	[XmlElement(ElementName="Rates")] 
	public Rates Rates { get; set; } = new Rates();
}

[XmlRoot(ElementName="RateSet")]
public class RateSet {
	public int Key { get; set; }
    public double MarkupPercent { get; set; }
    public double MarkupAmount { get; set; }
    [XmlElement(ElementName="Stay_Type")] 
	public string Stay_Type { get; set; } 

	[XmlElement(ElementName="Stay_Type2")] 
	public string Stay_Type2 { get; set; } 

	[XmlElement(ElementName="Rate_Text")] 
	public string Rate_Text { get; set; } 

	[XmlElement(ElementName="Rate_Text2")] 
	public string Rate_Text2 { get; set; } 

	[XmlElement(ElementName="Min_SCU")] 
	public int Min_SCU { get; set; } 

	[XmlElement(ElementName="Max_SCU")] 
	public int Max_SCU { get; set; } 

	[XmlElement(ElementName="Prov")] 
	public string Prov { get; set; } 

	[XmlElement(ElementName="Commissionable")] 
	public string Commissionable { get; set; }
    public bool Commissionable_chk { get; set; }

    [XmlElement(ElementName="Comm_Oride")] 
	public double Comm_Oride { get; set; } 

	[XmlElement(ElementName="Prefer")] 
	public int Prefer { get; set; } 

	[XmlElement(ElementName="Gross_Nett")] 
	public string Gross_Nett { get; set; } 

	[XmlElement(ElementName="Sell_Code")] 
	public string Sell_Code { get; set; }

    [XmlElement(ElementName="Apply_Mon")] 
	public string Apply_Mon { get; set; }
	public bool Apply_Mon_chk { get; set; } = false;

    [XmlElement(ElementName="Apply_Tue")] 
	public string Apply_Tue { get; set; }
    public bool Apply_Tue_chk { get; set; } = false;

    [XmlElement(ElementName="Apply_Wed")] 
	public string Apply_Wed { get; set; }
    public bool Apply_Wed_chk { get; set; } = false;

    [XmlElement(ElementName="Apply_Thu")] 
	public string Apply_Thu { get; set; }
    public bool Apply_Thu_chk { get; set; } = false;

    [XmlElement(ElementName="Apply_Fri")] 
	public string Apply_Fri { get; set; }
    public bool Apply_Fri_chk { get; set; } = false;

    [XmlElement(ElementName="Apply_Sat")] 
	public string Apply_Sat { get; set; }
    public bool Apply_Sat_chk { get; set; } = false;

    [XmlElement(ElementName="Apply_Sun")] 
	public string Apply_Sun { get; set; }
	public bool Apply_Sun_chk { get; set; } = false;

    [XmlElement(ElementName="Validate_Min_Max")] 
	public string Validate_Min_Max { get; set; } 

	[XmlElement(ElementName="Cancel_Hours")] 
	public int Cancel_Hours { get; set; } 

	[XmlElement(ElementName="Vtext1")] 
	public string Vtext1 { get; set; } 

	[XmlElement(ElementName="Vtext2")] 
	public string Vtext2 { get; set; } 

	[XmlElement(ElementName="Vtext3")] 
	public string Vtext3 { get; set; } 

	[XmlElement(ElementName="Vtext4")] 
	public string Vtext4 { get; set; } 

	[XmlElement(ElementName="Vtext5")] 
	public string Vtext5 { get; set; } 

	[XmlElement(ElementName="Vtext6")] 
	public string Vtext6 { get; set; } 

	[XmlElement(ElementName="Vtext7")] 
	public string Vtext7 { get; set; } 

	[XmlElement(ElementName="Vtext8")] 
	public string Vtext8 { get; set; } 

	[XmlElement(ElementName="Vtext9")] 
	public string Vtext9 { get; set; } 

	[XmlElement(ElementName="Vtext10")] 
	public string Vtext10 { get; set; } 

	[XmlElement(ElementName="Vtext11")] 
	public string Vtext11 { get; set; } 

	[XmlElement(ElementName="Vtext12")] 
	public string Vtext12 { get; set; } 

	[XmlElement(ElementName="Vtext13")] 
	public string Vtext13 { get; set; } 

	[XmlElement(ElementName="Vtext14")] 
	public string Vtext14 { get; set; } 

	[XmlElement(ElementName="Vtext15")] 
	public string Vtext15 { get; set; } 

	[XmlElement(ElementName="Vtext16")] 
	public string Vtext16 { get; set; } 

	[XmlElement(ElementName="Vtext17")] 
	public string Vtext17 { get; set; } 

	[XmlElement(ElementName="Vtext18")] 
	public string Vtext18 { get; set; } 

	[XmlElement(ElementName="Vtext19")] 
	public string Vtext19 { get; set; } 

	[XmlElement(ElementName="Vtext20")] 
	public string Vtext20 { get; set; } 

	[XmlElement(ElementName="EditVtext1")] 
	public string EditVtext1 { get; set; } 

	[XmlElement(ElementName="EditVtext2")] 
	public string EditVtext2 { get; set; } 

	[XmlElement(ElementName="EditVtext3")] 
	public string EditVtext3 { get; set; } 

	[XmlElement(ElementName="EditVtext4")] 
	public string EditVtext4 { get; set; } 

	[XmlElement(ElementName="EditVtext5")] 
	public string EditVtext5 { get; set; } 

	[XmlElement(ElementName="EditVtext6")] 
	public string EditVtext6 { get; set; } 

	[XmlElement(ElementName="EditVtext7")] 
	public string EditVtext7 { get; set; } 

	[XmlElement(ElementName="EditVtext8")] 
	public string EditVtext8 { get; set; } 

	[XmlElement(ElementName="EditVtext9")] 
	public string EditVtext9 { get; set; } 

	[XmlElement(ElementName="EditVtext10")] 
	public string EditVtext10 { get; set; } 

	[XmlElement(ElementName="EditVtext11")] 
	public string EditVtext11 { get; set; } 

	[XmlElement(ElementName="EditVtext12")] 
	public string EditVtext12 { get; set; } 

	[XmlElement(ElementName="EditVtext13")] 
	public string EditVtext13 { get; set; } 

	[XmlElement(ElementName="EditVtext14")] 
	public string EditVtext14 { get; set; } 

	[XmlElement(ElementName="EditVtext15")] 
	public string EditVtext15 { get; set; } 

	[XmlElement(ElementName="EditVtext16")] 
	public string EditVtext16 { get; set; } 

	[XmlElement(ElementName="EditVtext17")] 
	public string EditVtext17 { get; set; } 

	[XmlElement(ElementName="EditVtext18")] 
	public string EditVtext18 { get; set; } 

	[XmlElement(ElementName="EditVtext19")] 
	public string EditVtext19 { get; set; } 

	[XmlElement(ElementName="EditVtext20")] 
	public string EditVtext20 { get; set; } 

	[XmlElement(ElementName="GroupCost")] 
	public GroupCost GroupCost { get; set; } 

	[XmlElement(ElementName="FITCost")] 
	public FITCost FITCost { get; set; } 

	[XmlElement(ElementName="GroupSell")] 
	public GroupSell GroupSell { get; set; } 

	[XmlElement(ElementName="FITSell")] 
	public FITSell FITSell { get; set; }

    [XmlElement(ElementName = "Stay1")]
    public int? Stay1 { get; set; }

    [XmlElement(ElementName = "Pay1")]
    public int? Pay1 { get; set; }

    [XmlElement(ElementName = "Stay2")]
    public int? Stay2 { get; set; }

    [XmlElement(ElementName = "Pay2")]
    public int? Pay2 { get; set; }

    [XmlElement(ElementName = "Stay3")]
    public int? Stay3 { get; set; }

    [XmlElement(ElementName = "Pay3")]
    public int? Pay3 { get; set; }

    [XmlElement(ElementName = "Stay4")]
    public int? Stay4 { get; set; }

    [XmlElement(ElementName = "Pay4")]
    public int? Pay4 { get; set; }

    [XmlElement(ElementName = "Stay5")]
    public int? Stay5 { get; set; }

    [XmlElement(ElementName = "Pay5")]
    public int? Pay5 { get; set; }

    [XmlElement(ElementName = "Stay6")]
    public int? Stay6 { get; set; }

    [XmlElement(ElementName = "Pay6")]
    public int? Pay6 { get; set; }

    [XmlElement(ElementName = "Stay7")]
    public int? Stay7 { get; set; }

    [XmlElement(ElementName = "Pay7")]
    public int? Pay7 { get; set; }

    [XmlElement(ElementName = "Stay8")]
    public int? Stay8 { get; set; }

    [XmlElement(ElementName = "Pay8")]
    public int? Pay8 { get; set; }

    [XmlElement(ElementName = "Stay9")]
    public int? Stay9 { get; set; }

    [XmlElement(ElementName = "Pay9")]
    public int? Pay9 { get; set; }

    [XmlElement(ElementName = "Stay10")]
    public int? Stay10 { get; set; }

    [XmlElement(ElementName = "Pay10")]
    public int? Pay10 { get; set; }

    [XmlElement(ElementName = "StayPayType")]
    public int? StayPayType { get; set; }

    [XmlElement(ElementName = "Repeat_Times")]
    public int? RepeatTimes { get; set; }

   
}

[XmlRoot(ElementName="TaxInfo")]
public class TaxInfo { 

	[XmlElement(ElementName="Tax")] 
	public string Tax { get; set; } 

	[XmlElement(ElementName="TaxMainOption")] 
	public string TaxMainOption { get; set; } 

	[XmlElement(ElementName="TaxSs")] 
	public string TaxSs { get; set; } 

	[XmlElement(ElementName="TaxTr")] 
	public string TaxTr { get; set; } 

	[XmlElement(ElementName="TaxQr")] 
	public string TaxQr { get; set; } 

	[XmlElement(ElementName="TaxEx1")] 
	public string TaxEx1 { get; set; } 

	[XmlElement(ElementName="TaxEx2")] 
	public string TaxEx2 { get; set; } 

	[XmlElement(ElementName="TaxEx3")] 
	public string TaxEx3 { get; set; } 

	[XmlElement(ElementName="TaxEx4")] 
	public string TaxEx4 { get; set; } 

	[XmlElement(ElementName="TaxEx5")] 
	public string TaxEx5 { get; set; } 
}

[XmlRoot(ElementName="Taxes")]
public class Taxes { 

	[XmlElement(ElementName="TaxInfo")] 
	public TaxInfo TaxInfo { get; set; } = new TaxInfo();
}

[XmlRoot(ElementName="DateRange")]
public class DateRange { 

	[XmlElement(ElementName="OptionCode")] 
	public string OptionCode { get; set; } 

	[XmlElement(ElementName="Opt_ID")] 
	public int Opt_ID { get; set; } 

	[XmlElement(ElementName="LastUpdate")] 
	public DateTime LastUpdate { get; set; } 

	[XmlElement(ElementName="Price_Code")] 
	public string Price_Code { get; set; } 

	[XmlElement(ElementName="Date_From")] 
	public DateTime Date_From { get; set; } 

	[XmlElement(ElementName="Date_To")] 
	public DateTime Date_To { get; set; } 

	[XmlElement(ElementName="Sale_From")] 
	public DateTime Sale_From { get; set; } 

	[XmlElement(ElementName="Sale_To")] 
	public DateTime Sale_To { get; set; } 

	[XmlElement(ElementName="SellBeforeTravel")] 
	public int SellBeforeTravel { get; set; } 

	[XmlElement(ElementName="SellBeforeType")] 
	public string SellBeforeType { get; set; } 

	[XmlElement(ElementName="Buy_Currency")] 
	public string Buy_Currency { get; set; } 

	[XmlElement(ElementName="Sell_Currency")] 
	public string Sell_Currency { get; set; }

    [XmlElement(ElementName = "ChargeExtra1")]
    public string ChargeExtra1 { get; set; }
    public bool ChargeEx1_Check { get; set; } = false;

    [XmlElement(ElementName = "ChargeExtra2")]
    public string ChargeExtra2 { get; set; }
    public bool ChargeEx2_Check { get; set; } = false;

    [XmlElement(ElementName = "ChargeExtra3")]
    public string ChargeExtra3 { get; set; }
    public bool ChargeEx3_Check { get; set; } = false;

    [XmlElement(ElementName = "ChargeExtra4")]
    public string ChargeExtra4 { get; set; }
    public bool ChargeEx4_Check { get; set; } = false;

    [XmlElement(ElementName = "ChargeExtra5")]
    public string ChargeExtra5 { get; set; }
    public bool ChargeEx5_Check { get; set; } = false;

    [XmlElement(ElementName="RateSet")] 
	public List<RateSet> RateSet { get; set; } = new List<RateSet>();

	[XmlElement(ElementName="Taxes")] 
	public Taxes Taxes { get; set; } = new Taxes();
}

[XmlRoot(ElementName="GetRateReply")]
public class GetRateReply { 

	[XmlElement(ElementName="DateRange")] 
	public List<DateRange> DateRange { get; set; } = new List<DateRange>();
}

[XmlRoot(ElementName="Reply")]
public class ReplyFromGetRate { 

	[XmlElement(ElementName="GetRateReply")] 
	public GetRateReply GetRateReply { get; set; } = new GetRateReply();

 
}