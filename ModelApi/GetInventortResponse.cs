// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(Reply));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Reply)serializer.Deserialize(reader);
// }

using System.Xml.Serialization;

[XmlRoot(ElementName = "AllocationAppliesTo")]
public class AllocationAppliesTo
{

    [XmlElement(ElementName = "OptionCode")]
    public List<string> OptionCode { get; set; }

    [XmlElement(ElementName = "AllocationType")]
    public string AllocationType { get; set; }
}

[XmlRoot(ElementName = "Split")]
public class Split
{
    public bool SplitCode_check { get; set; } = true;
    [XmlElement(ElementName = "Split_Code")]
    public string SplitCode { get; set; }

    [XmlElement(ElementName = "UnitTypeInventory")]
    public UnitTypeInventory UnitTypeInventory { get; set; }
}

[XmlRoot(ElementName = "PerDayInventory")]
public class PerDayInventory
{

    [XmlElement(ElementName = "Date")]
    public DateTime Date { get; set; }

    [XmlElement(ElementName = "Release_Period")]
    public int ReleasePeriod { get; set; }

    [XmlElement(ElementName = "Max_Qty")]
    public int MaxQty { get; set; }

    [XmlElement(ElementName = "Bkd_Qty")]
    public int BkdQty { get; set; }

    [XmlElement(ElementName = "Released")]
    public string Released { get; set; }

    [XmlElement(ElementName = "Request_OK")]
    public string RequestOK { get; set; }

    private bool _RequestOK_Check;
    public bool RequestOk_Check
    {
        get
        {
            if (RequestOK == "Y")
            {
                _RequestOK_Check = true;
            }
            else
            {
                _RequestOK_Check = false;
            }
            return _RequestOK_Check;
        }
        set
        {
            _RequestOK_Check = value;
        }
    }

    public bool error = false;
}

[XmlRoot(ElementName = "UnitTypeInventory")]
public class UnitTypeInventory
{

    [XmlElement(ElementName = "Unit_Type")]
    public string UnitType { get; set; }

    [XmlElement(ElementName = "PerDayInventory")]
    public List<PerDayInventory> PerDayInventory { get; set; }
}

[XmlRoot(ElementName = "Allocation")]
public class Allocation
{
    public DateTime UpdateToTPdate { get; set; }
    public bool UpdateToTP { get; set; } = false;
    public bool ShowAllocation { get; set; } = true;
    [XmlElement(ElementName = "SupplierCode")]
    public string SupplierCode { get; set; }

    [XmlElement(ElementName = "AllocationName")]
    public string AllocationName { get; set; }

    [XmlElement(ElementName = "AllocationDescription")]
    public string AllocationDescription { get; set; }

    [XmlElement(ElementName = "Deleted")]
    public string Deleted { get; set; }

    [XmlElement(ElementName = "AllocationAppliesTo")]
    public AllocationAppliesTo AllocationAppliesTo { get; set; }

    [XmlElement(ElementName = "Split")]
    public List<Split> Split { get; set; }
}

[XmlRoot(ElementName = "GetInventoryReply")]
public class GetInventoryReply
{

    [XmlElement(ElementName = "Allocation")]
    public List<Allocation> Allocation { get; set; }
}

[XmlRoot(ElementName = "Reply")]
public class ReplyFromGetInventory
{

    [XmlElement(ElementName = "GetInventoryReply")]
    public GetInventoryReply GetInventoryReply { get; set; }
}

