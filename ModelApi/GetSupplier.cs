
    public class GetSupplier
    {
    public string SupplierCode { get; set; }
    public string SupplierName { get; set; }
    public IList<GetOption> Options { get; set; }
}

public class GetOption
{
    public int Opt_Id { get; set; }
    public string OptionName { get; set; }

    public string OptionCode { get; set; }
}

