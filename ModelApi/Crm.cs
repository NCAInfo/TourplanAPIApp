using System;
using System.Collections.Generic;

namespace DiethelmAPI.ModelDb;

public partial class Crm
{
    public string Code { get; set; }

    public string Name { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string Address3 { get; set; }

    public string Address4 { get; set; }

    public string Pcode { get; set; }

    public string AnalysisMaster1 { get; set; }

    public string AnalysisMaster2 { get; set; }

    public string AnalysisMaster3 { get; set; }

    public DateTime Created { get; set; }

    public string Taxindicator { get; set; }

    public decimal Commission { get; set; }

    public decimal Markup { get; set; }

    public string Language { get; set; }

    public string Supplierchain { get; set; }

    public string Suppliermaster { get; set; }

    public string DefaultCurrency { get; set; }

    public string Deleted { get; set; }

    public int CrmId { get; set; }

    public int Prefer { get; set; }

    public string ImportFormat { get; set; }

    public string ImportFileLocation { get; set; }

    public string Address5 { get; set; }

    public string Udtext1 { get; set; }

    public string Udtext2 { get; set; }

    public string Udtext3 { get; set; }

    public string Udtext4 { get; set; }

    public string Udtext5 { get; set; }

    public string CreatedBy { get; set; }

    public string EditedBy { get; set; }

    public DateTime EditedDate { get; set; }

    public string IntAccess { get; set; }

    public string IntLogin { get; set; }

    public string IntPassword { get; set; }

    public string MailingName { get; set; }

    public string MailingAddress1 { get; set; }

    public string MailingAddress2 { get; set; }

    public string MailingAddress3 { get; set; }

    public string MailingAddress4 { get; set; }

    public string MailingAddress5 { get; set; }

    public string MailingPcode { get; set; }

    public int VoucherUpdate { get; set; }

    public int SodId { get; set; }

    public string AnalysisMaster4 { get; set; }

    public string AnalysisMaster5 { get; set; }

    public string AnalysisMaster6 { get; set; }

    public string Udtext6 { get; set; }

    public string Udtext7 { get; set; }

    public string Udtext8 { get; set; }

    public string Udtext9 { get; set; }

    public string Udtext10 { get; set; }

    public int GlobalSupplierId { get; set; }

    public string Address1Local { get; set; }

    public string Address2Local { get; set; }

    public string Address3Local { get; set; }

    public string Address4Local { get; set; }

    public string Address5Local { get; set; }

    public string MailingAddress1Local { get; set; }

    public string MailingAddress2Local { get; set; }

    public string MailingAddress3Local { get; set; }

    public string MailingAddress4Local { get; set; }

    public string MailingAddress5Local { get; set; }

    public string MailingNameLocal { get; set; }

    public string NameLocal { get; set; }

    public string Udtext11 { get; set; }

    public string Udtext12 { get; set; }

    public string Udtext13 { get; set; }

    public string Udtext14 { get; set; }

    public string Udtext15 { get; set; }

    public string Udtext16 { get; set; }

    public string Udtext17 { get; set; }

    public string Udtext18 { get; set; }

    public string Udtext19 { get; set; }

    public string Udtext20 { get; set; }

    public string PcodeLocal { get; set; }

    public string MailingPcodeLocal { get; set; }

    public string NameInternet { get; set; }

    public bool Vccactive { get; set; }

    public virtual ICollection<Opt> Opts { get; set; } = new List<Opt>();

    public virtual ICollection<Pol> Pols { get; set; } = new List<Pol>();
}
