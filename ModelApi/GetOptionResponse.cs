// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(Reply));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Reply)serializer.Deserialize(reader);
// }

using System.Xml.Serialization;

[XmlRoot(ElementName="OptionGeneralData")]
public class OptionGeneralData { 

	[XmlElement(ElementName="OptionCode")] 
	public string OptionCode { get; set; } 

	[XmlElement(ElementName="Opt_ID")] 
	public int Opt_ID { get; set; } 

	[XmlElement(ElementName="Ac")] 
	public string Ac { get; set; } 

	[XmlElement(ElementName="Deleted")] 
	public string Deleted { get; set; } 

	[XmlElement(ElementName="Description")] 
	public string Description { get; set; } 

	[XmlElement(ElementName="Description2")] 
	public string Description2 { get; set; } 

	[XmlElement(ElementName="Comment")] 
	public string Comment { get; set; } 

	[XmlElement(ElementName="Comment2")] 
	public string Comment2 { get; set; } 

	[XmlElement(ElementName="Locality")] 
	public string Locality { get; set; } 

	[XmlElement(ElementName="Class")] 
	public string Class { get; set; } 

	[XmlElement(ElementName="Duration")] 
	public double Duration { get; set; } 

	[XmlElement(ElementName="Analysis1")] 
	public string Analysis1 { get; set; } 

	[XmlElement(ElementName="Analysis2")] 
	public string Analysis2 { get; set; } 

	[XmlElement(ElementName="Analysis3")] 
	public string Analysis3 { get; set; } 

	[XmlElement(ElementName="Analysis4")] 
	public string Analysis4 { get; set; } 

	[XmlElement(ElementName="Analysis5")] 
	public string Analysis5 { get; set; } 

	[XmlElement(ElementName="Analysis6")] 
	public string Analysis6 { get; set; } 

	[XmlElement(ElementName="Message_Code")] 
	public string Message_Code { get; set; } 

	[XmlElement(ElementName="Invoice_Text1")] 
	public string Invoice_Text1 { get; set; } 

	[XmlElement(ElementName="Invoice_Text2")] 
	public string Invoice_Text2 { get; set; } 

	[XmlElement(ElementName="Invoice_Text3")] 
	public string Invoice_Text3 { get; set; } 

	[XmlElement(ElementName="Invoice_Text4")] 
	public string Invoice_Text4 { get; set; } 

	[XmlElement(ElementName="Created_By")] 
	public string Created_By { get; set; } 

	[XmlElement(ElementName="Edited_By")] 
	public string Edited_By { get; set; } 

	[XmlElement(ElementName="Created")] 
	public DateTime Created { get; set; } 

	[XmlElement(ElementName="LastUpdate")] 
	public DateTime LastUpdate { get; set; } 
}

[XmlRoot(ElementName="OptionCostData")]
public class OptionCostData { 

	[XmlElement(ElementName="FCU")] 
	public string FCU { get; set; } 

	[XmlElement(ElementName="FCU_Local")] 
	public string FCU_Local { get; set; } 

	[XmlElement(ElementName="SCU")] 
	public string SCU { get; set; } 

	[XmlElement(ElementName="SCU_Local")] 
	public string SCU_Local { get; set; } 

	[XmlElement(ElementName="MPFCU")] 
	public int MPFCU { get; set; } 

	[XmlElement(ElementName="Periods")] 
	public int Periods { get; set; } 

	[XmlElement(ElementName="Periods_Base")] 
	public string Periods_Base { get; set; } 

	[XmlElement(ElementName="Pxb1")] 
	public int Pxb1 { get; set; } 

	[XmlElement(ElementName="Pxb2")] 
	public int Pxb2 { get; set; } 

	[XmlElement(ElementName="Pxb3")] 
	public int Pxb3 { get; set; } 

	[XmlElement(ElementName="Pxb4")] 
	public int Pxb4 { get; set; } 

	[XmlElement(ElementName="Pxb5")] 
	public int Pxb5 { get; set; } 

	[XmlElement(ElementName="Pxb6")] 
	public int Pxb6 { get; set; } 

	[XmlElement(ElementName="Pxb7")] 
	public int Pxb7 { get; set; } 

	[XmlElement(ElementName="Pxb8")] 
	public int Pxb8 { get; set; } 

	[XmlElement(ElementName="Pxb9")] 
	public int Pxb9 { get; set; } 

	[XmlElement(ElementName="Pxb10")] 
	public int Pxb10 { get; set; } 

	[XmlElement(ElementName="Pxb11")] 
	public int Pxb11 { get; set; } 

	[XmlElement(ElementName="Pxb12")] 
	public int Pxb12 { get; set; } 

	[XmlElement(ElementName="Pxb13")] 
	public int Pxb13 { get; set; } 

	[XmlElement(ElementName="Pxb14")] 
	public int Pxb14 { get; set; } 

	[XmlElement(ElementName="Pxb15")] 
	public int Pxb15 { get; set; } 

	[XmlElement(ElementName="Pxb16")] 
	public int Pxb16 { get; set; } 

	[XmlElement(ElementName="Pxb17")] 
	public int Pxb17 { get; set; } 

	[XmlElement(ElementName="Pxb18")] 
	public int Pxb18 { get; set; } 

	[XmlElement(ElementName="Pxb19")] 
	public int Pxb19 { get; set; } 

	[XmlElement(ElementName="Pxb20")] 
	public int Pxb20 { get; set; } 

	[XmlElement(ElementName="Pxb21")] 
	public int Pxb21 { get; set; } 

	[XmlElement(ElementName="Pxb22")] 
	public int Pxb22 { get; set; } 

	[XmlElement(ElementName="Pxb23")] 
	public int Pxb23 { get; set; } 

	[XmlElement(ElementName="Pxb24")] 
	public int Pxb24 { get; set; } 

	[XmlElement(ElementName="Child_In_Pxb")] 
	public string Child_In_Pxb { get; set; } 

	[XmlElement(ElementName="Infant_In_Pxb")] 
	public string Infant_In_Pxb { get; set; } 

	[XmlElement(ElementName="Ex1")] 
	public string Ex1 { get; set; } 

	[XmlElement(ElementName="Ex2")] 
	public string Ex2 { get; set; } 

	[XmlElement(ElementName="Ex3")] 
	public string Ex3 { get; set; } 

	[XmlElement(ElementName="Ex4")] 
	public string Ex4 { get; set; } 

	[XmlElement(ElementName="Ex5")] 
	public string Ex5 { get; set; } 

	[XmlElement(ElementName="Ex1_Local")] 
	public string Ex1_Local { get; set; } 

	[XmlElement(ElementName="Ex2_Local")] 
	public string Ex2_Local { get; set; } 

	[XmlElement(ElementName="Ex3_Local")] 
	public string Ex3_Local { get; set; } 

	[XmlElement(ElementName="Ex4_Local")] 
	public string Ex4_Local { get; set; } 

	[XmlElement(ElementName="Ex5_Local")] 
	public string Ex5_Local { get; set; } 

	[XmlElement(ElementName="ChgEx1")] 
	public string ChgEx1 { get; set; } 

	[XmlElement(ElementName="ChgEx2")] 
	public string ChgEx2 { get; set; } 

	[XmlElement(ElementName="ChgEx3")] 
	public string ChgEx3 { get; set; } 

	[XmlElement(ElementName="ChgEx4")] 
	public string ChgEx4 { get; set; } 

	[XmlElement(ElementName="ChgEx5")] 
	public string ChgEx5 { get; set; } 

	[XmlElement(ElementName="Ex1Description")] 
	public string Ex1Description { get; set; } 

	[XmlElement(ElementName="Ex2Description")] 
	public string Ex2Description { get; set; } 

	[XmlElement(ElementName="Ex3Description")] 
	public string Ex3Description { get; set; } 

	[XmlElement(ElementName="Ex4Description")] 
	public string Ex4Description { get; set; } 

	[XmlElement(ElementName="Ex5Description")] 
	public string Ex5Description { get; set; } 

	[XmlElement(ElementName="Ex1Description_Local")] 
	public string Ex1Description_Local { get; set; } 

	[XmlElement(ElementName="Ex2Description_Local")] 
	public string Ex2Description_Local { get; set; } 

	[XmlElement(ElementName="Ex3Description_Local")] 
	public string Ex3Description_Local { get; set; } 

	[XmlElement(ElementName="Ex4Description_Local")] 
	public string Ex4Description_Local { get; set; } 

	[XmlElement(ElementName="Ex5Description_Local")] 
	public string Ex5Description_Local { get; set; } 

	[XmlElement(ElementName="Int_Hide_Ex1")] 
	public string Int_Hide_Ex1 { get; set; } 

	[XmlElement(ElementName="Int_Hide_Ex2")] 
	public string Int_Hide_Ex2 { get; set; } 

	[XmlElement(ElementName="Int_Hide_Ex3")] 
	public string Int_Hide_Ex3 { get; set; } 

	[XmlElement(ElementName="Int_Hide_Ex4")] 
	public string Int_Hide_Ex4 { get; set; } 

	[XmlElement(ElementName="Int_Hide_Ex5")] 
	public string Int_Hide_Ex5 { get; set; } 
}

[XmlRoot(ElementName="OptionVoucherData")]
public class OptionVoucherData { 

	[XmlElement(ElementName="V_Prod")] 
	public string V_Prod { get; set; } 

	[XmlElement(ElementName="Vch_ProdCode")] 
	public string Vch_ProdCode { get; set; } 

	[XmlElement(ElementName="Vname")] 
	public string Vname { get; set; } 

	[XmlElement(ElementName="Vadd1")] 
	public string Vadd1 { get; set; } 

	[XmlElement(ElementName="Vadd2")] 
	public string Vadd2 { get; set; } 

	[XmlElement(ElementName="Vadd3")] 
	public string Vadd3 { get; set; } 

	[XmlElement(ElementName="Vadd4")] 
	public string Vadd4 { get; set; } 

	[XmlElement(ElementName="Vadd5")] 
	public string Vadd5 { get; set; } 

	[XmlElement(ElementName="PCode")] 
	public int PCode { get; set; } 

	[XmlElement(ElementName="Vname_Local")] 
	public string Vname_Local { get; set; } 

	[XmlElement(ElementName="Vadd1_Local")] 
	public string Vadd1_Local { get; set; } 

	[XmlElement(ElementName="Vadd2_Local")] 
	public string Vadd2_Local { get; set; } 

	[XmlElement(ElementName="Vadd3_Local")] 
	public string Vadd3_Local { get; set; } 

	[XmlElement(ElementName="Vadd4_Local")] 
	public string Vadd4_Local { get; set; } 

	[XmlElement(ElementName="Vadd5_Local")] 
	public string Vadd5_Local { get; set; } 

	[XmlElement(ElementName="PCode_Local")] 
	public string PCode_Local { get; set; } 

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
}

[XmlRoot(ElementName="OptionInternetData")]
public class OptionInternetData { 

	[XmlElement(ElementName="Int_Option")] 
	public string Int_Option { get; set; } 

	[XmlElement(ElementName="Int_Moreinfourl")] 
	public string Int_Moreinfourl { get; set; } 

	[XmlElement(ElementName="Int_Def_Avail")] 
	public string Int_Def_Avail { get; set; } 

	[XmlElement(ElementName="Int_Supplier_Access")] 
	public string Int_Supplier_Access { get; set; } 

	[XmlElement(ElementName="Int_Sale_Fm")] 
	public DateTime Int_Sale_Fm { get; set; } 

	[XmlElement(ElementName="Int_Sale_To")] 
	public DateTime Int_Sale_To { get; set; } 
}

[XmlRoot(ElementName="OptionEnquiryNote")]
public class OptionEnquiryNote { 

	[XmlElement(ElementName="Category")] 
	public string Category { get; set; } 

	[XmlElement(ElementName="Message_Text")] 
	public string Message_Text { get; set; } 
}

[XmlRoot(ElementName="OptionEnquiryNotes")]
public class OptionEnquiryNotes { 

	[XmlElement(ElementName="OptionEnquiryNote")] 
	public List<OptionEnquiryNote> OptionEnquiryNote { get; set; } 
}

[XmlRoot(ElementName="RatePolicy")]
public class RatePolicy { 

	[XmlElement(ElementName="Single_Avail")] 
	public string Single_Avail { get; set; } 

	[XmlElement(ElementName="Single_Max")] 
	public int Single_Max { get; set; } 

	[XmlElement(ElementName="Single_Ad_Max")] 
	public int Single_Ad_Max { get; set; } 

	[XmlElement(ElementName="Twin_Avail")] 
	public string Twin_Avail { get; set; } 

	[XmlElement(ElementName="Twin_Max")] 
	public int Twin_Max { get; set; } 

	[XmlElement(ElementName="Twin_Ad_Max")] 
	public int Twin_Ad_Max { get; set; } 

	[XmlElement(ElementName="Double_Avail")] 
	public string Double_Avail { get; set; } 

	[XmlElement(ElementName="Double_Max")] 
	public int Double_Max { get; set; } 

	[XmlElement(ElementName="Double_Ad_Max")] 
	public int Double_Ad_Max { get; set; } 

	[XmlElement(ElementName="Triple_Avail")] 
	public string Triple_Avail { get; set; } 

	[XmlElement(ElementName="Triple_Max")] 
	public int Triple_Max { get; set; } 

	[XmlElement(ElementName="Triple_Ad_Max")] 
	public int Triple_Ad_Max { get; set; } 

	[XmlElement(ElementName="Quad_Avail")] 
	public string Quad_Avail { get; set; } 

	[XmlElement(ElementName="Quad_Max")] 
	public int Quad_Max { get; set; } 

	[XmlElement(ElementName="Quad_Ad_Max")] 
	public int Quad_Ad_Max { get; set; } 

	[XmlElement(ElementName="Other_Avail")] 
	public string Other_Avail { get; set; } 

	[XmlElement(ElementName="Other_Max")] 
	public int Other_Max { get; set; } 

	[XmlElement(ElementName="Other_Ad_Max")] 
	public int Other_Ad_Max { get; set; } 

	[XmlElement(ElementName="Infant_From")] 
	public int Infant_From { get; set; } 

	[XmlElement(ElementName="Infant_To")] 
	public int Infant_To { get; set; } 

	[XmlElement(ElementName="Child_From")] 
	public int Child_From { get; set; } 

	[XmlElement(ElementName="Child_To")] 
	public int Child_To { get; set; } 

	[XmlElement(ElementName="Adult_From")] 
	public int Adult_From { get; set; } 

	[XmlElement(ElementName="Adult_To")] 
	public int Adult_To { get; set; } 

	[XmlElement(ElementName="Start_Mon")] 
	public string Start_Mon { get; set; } 

	[XmlElement(ElementName="Start_Tue")] 
	public string Start_Tue { get; set; } 

	[XmlElement(ElementName="Start_Wed")] 
	public string Start_Wed { get; set; } 

	[XmlElement(ElementName="Start_Thu")] 
	public string Start_Thu { get; set; } 

	[XmlElement(ElementName="Start_Fri")] 
	public string Start_Fri { get; set; } 

	[XmlElement(ElementName="Start_Sat")] 
	public string Start_Sat { get; set; } 

	[XmlElement(ElementName="Start_Sun")] 
	public string Start_Sun { get; set; } 

	[XmlElement(ElementName="Include_Mon")] 
	public string Include_Mon { get; set; } 

	[XmlElement(ElementName="Include_Tue")] 
	public string Include_Tue { get; set; } 

	[XmlElement(ElementName="Include_Wed")] 
	public string Include_Wed { get; set; } 

	[XmlElement(ElementName="Include_Thu")] 
	public string Include_Thu { get; set; } 

	[XmlElement(ElementName="Include_Fri")] 
	public string Include_Fri { get; set; } 

	[XmlElement(ElementName="Include_Sat")] 
	public string Include_Sat { get; set; } 

	[XmlElement(ElementName="Include_Sun")] 
	public string Include_Sun { get; set; } 

	[XmlElement(ElementName="Cross_Season")] 
	public string Cross_Season { get; set; } 

	[XmlElement(ElementName="Pickup")] 
	public string Pickup { get; set; } 
}

[XmlRoot(ElementName="SellingChannels")]
public class SellingChannels { 

	[XmlElement(ElementName="AllowTourplanUI")] 
	public string AllowTourplanUI { get; set; } 

	[XmlElement(ElementName="AllowHostConnect")] 
	public string AllowHostConnect { get; set; } 

	[XmlElement(ElementName="AllowWebConnect")] 
	public string AllowWebConnect { get; set; } 
}

[XmlRoot(ElementName="OptionData")]
public class OptionData { 

	[XmlElement(ElementName="OptionGeneralData")] 
	public OptionGeneralData OptionGeneralData { get; set; } 

	[XmlElement(ElementName="OptionCostData")] 
	public OptionCostData OptionCostData { get; set; } 

	[XmlElement(ElementName="OptionVoucherData")] 
	public OptionVoucherData OptionVoucherData { get; set; } 

	[XmlElement(ElementName="OptionInternetData")] 
	public OptionInternetData OptionInternetData { get; set; } 

	[XmlElement(ElementName="OptionEnquiryNotes")] 
	public OptionEnquiryNotes OptionEnquiryNotes { get; set; } 

	[XmlElement(ElementName="RatePolicyLevel")] 
	public string RatePolicyLevel { get; set; } 

	[XmlElement(ElementName="RatePolicy")] 
	public RatePolicy RatePolicy { get; set; } 

	[XmlElement(ElementName="SellingChannelLevel")] 
	public string SellingChannelLevel { get; set; } 

	[XmlElement(ElementName="SellingChannels")] 
	public SellingChannels SellingChannels { get; set; } 
}

[XmlRoot(ElementName="GetOptionReply")]
public class GetOptionReply { 

	[XmlElement(ElementName="OptionData")] 
	public List<OptionData> OptionData { get; set; } 
}

[XmlRoot(ElementName="Reply")]
public class GetOptionReplyRoot { 

	[XmlElement(ElementName="GetOptionReply")] 
	public GetOptionReply GetOptionReply { get; set; } 
}

