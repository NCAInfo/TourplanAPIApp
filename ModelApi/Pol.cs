using System;
using System.Collections.Generic;

namespace DiethelmAPI.ModelDb;

public partial class Pol
{
    public int PolId { get; set; }

    public string SupplierCode { get; set; }

    public int OptId { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    public string ServiceCode { get; set; }

    public string MessageFormatCode { get; set; }

    public string DatabaseAnalysisCode1 { get; set; }

    public string DatabaseAnalysisCode2 { get; set; }

    public string DatabaseAnalysisCode3 { get; set; }

    public string DatabaseAnalysisCode4 { get; set; }

    public string DatabaseAnalysisCode5 { get; set; }

    public string DatabaseAnalysisCode6 { get; set; }

    public string ApplyMarkup { get; set; }

    public decimal MarkupPc { get; set; }

    public string ApplyCommission { get; set; }

    public decimal CommissionPc { get; set; }

    public string InvoiceText1 { get; set; }

    public string InvoiceText2 { get; set; }

    public bool AppliesExt { get; set; }

    public string BookingType { get; set; }

    public string InvoiceText3 { get; set; }

    public string InvoiceText4 { get; set; }

    public bool ExternalFees { get; set; }

    public virtual Db1 DatabaseAnalysisCode1Navigation { get; set; }

    public virtual Db2 DatabaseAnalysisCode2Navigation { get; set; }

    public virtual Db3 DatabaseAnalysisCode3Navigation { get; set; }

    public virtual Db4 DatabaseAnalysisCode4Navigation { get; set; }

    public virtual Db5 DatabaseAnalysisCode5Navigation { get; set; }

    public virtual Db6 DatabaseAnalysisCode6Navigation { get; set; }

   
    public virtual Srv ServiceCodeNavigation { get; set; }

    public virtual Crm SupplierCodeNavigation { get; set; }

    public virtual ICollection<Xlm> Xlms { get; set; } = new List<Xlm>();
}
